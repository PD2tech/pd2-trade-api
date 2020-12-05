using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Exceptions {
    public class EntityNotFoundException : Pd2TradeApiException {
        public EntityNotFoundException(string message) : base(message) { }
    }
}
