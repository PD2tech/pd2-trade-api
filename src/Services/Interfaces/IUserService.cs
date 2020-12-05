using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models;
using Pd2TradeApi.Server.Models.DTOs.User.Request;
using Pd2TradeApi.Server.Models.DTOs.User.Response;
using DevExtreme.AspNet.Data.ResponseModel;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Services.Interfaces
{
    public interface IUserService
    {
        Task<LoginResponse> Authenticate(string username, string password, string token, string ip, bool isAdmin = false);
        Task<LoginResponse> CreateUser(RegisterUserDto user);
        Task<UserResponse> GetById(long id);
        Task<bool> CheckEmail(string email);
        Task<UserResponse> FindByEmail(RequestResetPasswordRequest data);
        Task<bool> SendResetPasswordEmail(RequestResetPasswordRequest data);
        Task<LoginResponse> RefreshToken(long id);
        Task<bool> ResetPasswordByToken(ResetPasswordRequest request);
        Task<UserResponse> GetProfile(long id);
        Task<bool> DeleteUser(long id);
    }
}