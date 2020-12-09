using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("ItemStatTradeOffer")]
    public class ItemStatTradeOffer
    {
        public long TradeOfferId {get; set;}
        public TradeOffer TradeOffer {get; set;}
        public long ItemStatId {get; set;}
        public ItemStat ItemStat {get; set;}
        public float Value {get; set;}
    }
}
