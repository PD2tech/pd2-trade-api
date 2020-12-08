using Pd2TradeApi.Server.Models.Abstracts;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    public class FilterTradeOffersRequest
    {
        public string ItemName { get; set; }
        public float? Cost { get; set; }
        public string AccountName { get; set; }
        public string Note { get; set; }
        public long? WantedItemId { get; set; }
        public long? PosterId { get; set; }
        public List<ItemStatFilter> ItemStats { get; set; }
        public ItemFilter ItemFilters { get; set; }
        public int Page { get; set; }
    }
}
