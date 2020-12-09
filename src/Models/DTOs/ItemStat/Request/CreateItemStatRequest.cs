using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Models.DTOs.ItemStat.Request
{
    public class CreateItemStatFromTradeRequest
    {
        public long Id {get; set;}
        public float Value { get; set; }
    }
}
