using Pd2TradeApi.Server.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("ItemStat")]
    public class ItemStat : BaseEntity
    {
        public string Code { get; set; }
        public string Name {get; set;}
        public string DisplayName {get; set;}
        public float? MinValue {get; set;}
        public float? MaxValue {get; set;}
        public List<ItemStatTradeOffer> TradeOffers {get; set;}
    }
}
