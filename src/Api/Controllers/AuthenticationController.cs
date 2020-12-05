using System;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Lib.Extensions;
using Pd2TradeApi.Server.Models;
using Pd2TradeApi.Server.Models.DTOs.User.Request;
using Pd2TradeApi.Server.Models.DTOs.User.Response;
using Pd2TradeApi.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(LoginResponse), 200)]
        public async Task<IActionResult> Login(RegisterUserDto loginRequest)
        {
            loginRequest.Ip = User.GetIp(Request?.Headers, HttpContext);
            Request.Headers.TryGetValue("Origin", out var originValues);
            var loginResponse = await _userService.Authenticate(loginRequest.Email, loginRequest.Password, loginRequest.Token, loginRequest.Ip, originValues.Any(x => x.Contains("admin.Pd2TradeApi.com") || x.Contains("qa-admin.Pd2TradeApi.com")));
            if (loginResponse == null)
            {
                throw new InvalidCredentialException("Invalid Email or Password");
            }

            return Ok(loginResponse);
        }

        [Authorize]
        [HttpGet("Profile")]
        [ProducesResponseType(typeof(UserResponse), 200)]
        public async Task<IActionResult> Profile()
        {
            var userId = User.GetId();
            var user = await _userService.GetProfile(userId);

            return Ok(user);
        }

        [Authorize]
        [HttpGet("RefreshToken")]
        [ProducesResponseType(typeof(LoginResponse), 200)]
        public async Task<IActionResult> RefreshToken() {
            var loginResponse = await _userService.RefreshToken(User.GetId());
            return Ok(loginResponse);
        }

        [HttpPost("RequestResetPassword")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> RequestPasswordReset([FromBody]RequestResetPasswordRequest data)
        {
            var user = await _userService.FindByEmail(data);

            if (user == null)
            {
                return Ok(true);
            }

            await _userService.SendResetPasswordEmail(data);

            return Ok(true);
        }

        [HttpPost("ResetPassword")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> ResetPassword([FromBody]ResetPasswordRequest data)
        {
            var status = await _userService.ResetPasswordByToken(data);

            return Ok(status);
        }
    }
}
