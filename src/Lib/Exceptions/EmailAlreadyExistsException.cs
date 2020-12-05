using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Exceptions{
    public class EmailAlreadyExistsException : Pd2TradeApiException
    {
        public EmailAlreadyExistsException(string message) : base(message) { }
    }
}
