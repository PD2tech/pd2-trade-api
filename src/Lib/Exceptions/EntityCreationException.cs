using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Exceptions {
    public class EntityCreationException : Pd2TradeApiException {
        public EntityCreationException(string message) : base(message) { }
    }
}
