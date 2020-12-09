using Pd2TradeApi.Server.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("Runeword")]
    public class Runeword : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public long SocketsNeeded { get; set; }
        public List<ItemStat> ItemStats { get; set; }
    }
}
