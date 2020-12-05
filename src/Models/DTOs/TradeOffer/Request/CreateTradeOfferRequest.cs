using Pd2TradeApi.Server.Models.Abstracts;
using System;
using System.Collections.Generic;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    public class CreateTradeOfferRequest
    {
        public string ItemName { get; set; }
        public float? Cost { get; set; }
        public string AccountName { get; set; }
        public long? OfferedItemId { get; set; }
        public Item OfferedItem { get; set; }
        public long WantedItemId { get; set; }
        public List<CreateItemStatsWithTradeOfferRequest> ItemStats {get; set;}
    }
}
