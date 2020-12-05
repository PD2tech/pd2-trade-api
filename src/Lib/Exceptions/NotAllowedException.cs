using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Exceptions {
    public class NotAllowedException : Pd2TradeApiException {
        public NotAllowedException(string message) : base(message) { }
    }
}
