using Pd2TradeApi.Server.Models.Abstracts;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;
using System;
using System.Collections.Generic;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    public class CreateTradeOfferRequest
    {
        public float? Cost { get; set; }
        public string AccountName { get; set; }
        public long? OfferedItemId { get; set; }
        public CreateItemFromTradeRequest OfferedItem { get; set; }
        public long WantedItemId { get; set; }
        public List<CreateItemStatsWithTradeOfferRequest> ItemStats {get; set;}
    }
}
