using Pd2TradeApi.Server.Models.Abstracts;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;
using System;
using System.Collections.Generic;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    public class TradeOfferResponse : BaseEntity
    {
        public string ItemName { get; set; }
        public float? Cost { get; set; }
        public string AccountName { get; set; }
        public long OfferedItemId { get; set; }
        public ItemResponse OfferedItem { get; set; }
        public long WantedItemId { get; set; }
        public TradeOfferItemResponse WantedItem { get; set; }
    }
}
