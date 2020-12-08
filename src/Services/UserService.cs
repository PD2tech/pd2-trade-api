using System.Threading.Tasks;
using Pd2TradeApi.Server.Models;
using Pd2TradeApi.Server.Services.Interfaces;
using System.Text;
using System;
using Microsoft.AspNetCore.Identity;
using Pd2TradeApi.Server.Models.DTOs.User.Response;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Pd2TradeApi.Server.Configuration;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Models.DTOs.User.Request;
using System.Linq;
using Lib.Exceptions;
using Pd2TradeApi.Server.Models.DatabaseModels;
using AutoMapper;

namespace Pd2TradeApi.Server.Services
{
    public class UserService : IUserService
    {
        private readonly SignInManager<User> _signinManager;
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepo;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepo,
            SignInManager<User> signinManager,
            IConfiguration config,
            UserManager<User> userManager,
            IMapper mapper
        ){
            _userRepo = userRepo;
            _signinManager = signinManager;
            _config = config;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Authenticate(string email, string password, string token, bool isAdmin = false)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return null;

            var user = await _userRepo.GetByEmailAsync(email);

            if (user == null)
                return null;

            var roles = await _userRepo.GetRolesAsync(user.Id);

            //Do not allow users without roles into admin panel
            if(!roles.Any() && isAdmin) {
                return null;
            }

            if (string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                await _userManager.UpdateSecurityStampAsync(user);
                await SendResetPasswordEmail(new RequestResetPasswordRequest{Email = user.Email});
                return new LoginResponse {
                    Id = user.Id,
                    ResetPassword = true
                };
            }

            var result = await _signinManager.PasswordSignInAsync(email, password.Trim(), false, true);
            if (!result.Succeeded) {
                if (result.RequiresTwoFactor) {
                    if (string.IsNullOrEmpty(token)) {
                        return new LoginResponse {
                            TokenRequired = true
                        };
                    }

                    if(!await _userManager.VerifyTwoFactorTokenAsync(user, _userManager.Options.Tokens.AuthenticatorTokenProvider, token))
                        return null;
                } else
                    return null;
            }

            await _userRepo.UpdateAsync(user);
            return new LoginResponse {
                Token = GenerateJwtToken(user, roles.FirstOrDefault()),
                ExpiresAt = roles.Any() ? DateTimeOffset.UtcNow.AddMinutes(90).ToUnixTimeMilliseconds() : DateTimeOffset.UtcNow.AddMinutes(40320).ToUnixTimeMilliseconds(),
                Id = user.Id
            };
        }

        public async Task<LoginResponse> RefreshToken(long id) {
            var user = await _userRepo.GetByIdAsync(id);
            var roles = await _userRepo.GetRolesAsync(id);

            return new LoginResponse {
                Token = GenerateJwtToken(user, roles.FirstOrDefault()),
                ExpiresAt = roles.Any() ? DateTimeOffset.UtcNow.AddMinutes(90).ToUnixTimeMilliseconds() : DateTimeOffset.UtcNow.AddMinutes(40320).ToUnixTimeMilliseconds(),
                Id = user.Id
            };
        }

        private string GenerateJwtToken(User user, string role) {
            var expires = DateTime.UtcNow.AddMinutes(40320);

            var payload = new JwtPayload {
                { "sub", user.Id.ToString() },
                { "jti", Guid.NewGuid().ToString() },
                { "id", user.Id.ToString() },
                { "exp", (int)expires.Subtract(new DateTime(1970, 1, 1)).TotalSeconds }
            };
            
            payload.Add(ClaimTypes.Role, role);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.JwtKey()));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(new JwtHeader(creds), payload);

            var stringToken = new JwtSecurityTokenHandler().WriteToken(token);

            return stringToken;
        }

        public async Task<LoginResponse> CreateUser(RegisterUserDto registerUser)
        {
            var existingUser = await _userRepo.GetByEmailAsync(registerUser.Email);

            if (existingUser != null)
            {
                return null;
            }

            var user = new User();
            user.UserName = user.Email;
            user.Password = null;
            user.Email = registerUser.Email;

            await _userRepo.CreateAsync(user, registerUser.Password);
            return await Authenticate(registerUser.Email, registerUser.Password, null);
        }

        public async Task<UserResponse> FindByEmail(RequestResetPasswordRequest data)
        {
            return _mapper.Map<UserResponse>(await _userRepo.GetByEmailAsync(data.Email));
        }

        public async Task<bool> SendResetPasswordEmail(RequestResetPasswordRequest data) {
            var user = await _userRepo.GetByEmailAsync(data.Email);

            if (user == null)
            {
                return true;
            }

            var token = await _userRepo.GeneratePasswordResetTokenAsync(user.Id);

            return true;
        }

        public async Task<bool> ResetPasswordByToken(ResetPasswordRequest request) {
            return await _userRepo.ResetPasswordAsync(request.Email, request.NewPassword, Base64UrlEncoder.Decode(request.AccessToken));
        }

        public async Task<UserResponse> GetById(long id)
        {
            var toReturn = await _userRepo.GetByIdAsync(id);
            return _mapper.Map<UserResponse>(toReturn);
        }

        public async Task<UserResponse> GetProfile(long id)
        {
            var user = await _userRepo.GetByIdAsync(id);

            if (user != null)
            {
                return _mapper.Map<UserResponse>(user);
            }
            throw new EntityNotFoundException("User not found on profile route - ID: " + id);
        }

        public async Task<bool> CheckEmail(string email)
        {
            var user = await _userRepo.GetByEmailAsync(email);

            return user != null;
        }

        public async Task<bool> DeleteUser(long id)
        {
            return await _userRepo.DeleteAsync(id);
        }
    }
}
