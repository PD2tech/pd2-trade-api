﻿namespace Pd2TradeApi.Server.Models.DTOs.User.Request
{
    public class RequestResetPasswordRequest
    {
        public string Email { get; set; }
        public string WebsiteShortCode { get; set; }
    }
}
