using Pd2TradeApi.Server.Models.Abstracts;
using System;
using System.Collections.Generic;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    public class UserResponse
    {
        public string AccountName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<TradeOffer> Offers { get; set; }
    }
}
