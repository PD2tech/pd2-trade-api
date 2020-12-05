using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Exceptions {
    public class InvalidEntityException : Pd2TradeApiException {
        public InvalidEntityException(string message) : base(message) { }
    }
}
