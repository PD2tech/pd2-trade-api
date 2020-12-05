using Pd2TradeApi.Server.Lib.Extensions;
using Pd2TradeApi.Server.Models.DTOs.User.Request;
using Pd2TradeApi.Server.Models.DTOs.User.Response;
using Pd2TradeApi.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DTOs.Shared;

namespace Pd2TradeApi.Server.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAvailableRoles")]
        [ProducesResponseType(typeof(List<string>), 200)]
        public async Task<IActionResult> GetAvailableRoles()
        {
            return Ok(Enum.GetNames(typeof(AuthorizationPolicyType)));
        }

        [AllowAnonymous]
        [HttpGet("CheckEmail")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> CheckEmail(string email)
        {
            return Ok(await _userService.CheckEmail(email));
        }

        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(typeof(LoginResponse), 200)]
        public async Task<IActionResult> Register([FromBody]RegisterUserDto user)
        {
            if (user.Email == null)
            {
                return BadRequest("Email Required");
            }
            user.Ip = User.GetIp(Request?.Headers, HttpContext);
            var loginResponse = await _userService.CreateUser(user);

            if (loginResponse == null)
            { 
                return BadRequest("Failed to Register");
            }

            return Ok(loginResponse);
        }
    }
}
