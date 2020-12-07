using Pd2TradeApi.Server.Models.Abstracts;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Models.DTOs.Runeword.Request
{
    public class RunewordResponse : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public long SocketsNeeded { get; set; }
        public List<ItemStatResponse> Stats { get; set; }
    }
}
