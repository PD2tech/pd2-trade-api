using System;
using System.Collections.Generic;
using System.Text;

namespace Pd2TradeApi.Server.Models.DTOs.Error {
    public enum ErrorReason {
        Unauthorized,
        ServerError,
        ValidationError,
        InvalidData
    }
}
