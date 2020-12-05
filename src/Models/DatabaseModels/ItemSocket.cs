using Pd2TradeApi.Server.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("ItemSocket")]
    public class ItemSocket : BaseEntity
    {
        public long ItemId { get; set; }
        public Item Item { get; set; }
        public List<ItemStat> Stats { get; set; }
    }
}
