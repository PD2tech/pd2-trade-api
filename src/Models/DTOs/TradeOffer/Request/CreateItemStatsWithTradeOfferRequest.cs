using Pd2TradeApi.Server.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    public class CreateItemStatsWithTradeOfferRequest
    {
        public long ItemStatId { get; set; }
        public float Value { get; set; }
    }
}
