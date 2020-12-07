using Pd2TradeApi.Server.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("TradeOffer")]
    public class TradeOffer : BaseEntity
    {
        public string ItemName { get; set; }
        public float? Cost { get; set; }
        public string AccountName { get; set; }
        public string Note { get; set; }
        public long? OfferedItemId { get; set; }
        public Item OfferedItem { get; set; }
        public long? WantedItemId { get; set; }
        public Item WantedItem {get; set; }
        public List<ItemStatTradeOffer> ItemStats { get; set; }
        public long PosterId { get; set; }
        public User Poster { get; set; }
    }
}
