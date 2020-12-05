using System;
using System.Collections.Generic;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Models.DTOs.Shared
{
    public class TradeFilterRequest
    {
        public string Name {get; set;}
        public string ItemCategory {get; set;}
        public string ItemRarity {get; set;}
        public List<RequirementFilter> Requirements {get; set;}
        public List<DatabaseModels.ItemStat> Stats {get; set;}
    }
}
