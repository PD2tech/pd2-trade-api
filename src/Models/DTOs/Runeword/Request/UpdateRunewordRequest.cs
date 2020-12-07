using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;

namespace Pd2TradeApi.Server.Models.DTOs.Runeword.Request
{
    public class UpdateRunewordRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long SocketsNeeded { get; set; }
        public List<ItemStatResponse> Stats { get; set; }
    }
}
