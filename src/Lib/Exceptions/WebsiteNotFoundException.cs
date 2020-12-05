using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Exceptions {
    public class WebsiteNotFoundException : Pd2TradeApiException {
        public string Website { get; private set; }
        public WebsiteNotFoundException(string website, string message) : base(message) {
            Website = website;
        }
    }
}
