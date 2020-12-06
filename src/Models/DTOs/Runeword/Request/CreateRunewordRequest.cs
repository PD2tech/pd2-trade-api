using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Models.DTOs.ItemStat.Request
{
    public class CreateRunewordRequest
    {
        public string Name { get; set; }
        public long SocketsNeeded { get; set; }
        public List<ItemStatResponse> Stats { get; set; }
    }
}
