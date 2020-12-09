using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.Abstracts;

namespace Pd2TradeApi.Server.Models.DTOs.Item.Request
{
    public class TradeOfferItemResponse : BaseEntity
    {
        public string Name { get; set; }
    }
}
