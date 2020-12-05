using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Exceptions {
    public class Pd2TradeApiException : Exception {
        public Pd2TradeApiException(string message) : base(message) { }
    }
}
