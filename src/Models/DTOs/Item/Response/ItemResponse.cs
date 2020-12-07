﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.Abstracts;

namespace Pd2TradeApi.Server.Models.DTOs.ItemStat.Request
{
    public class ItemResponse : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int? StrengthRequirement { get; set; }
        public int? DexterityRequirement { get; set; }
        public int? LevelRequirement { get; set; }
        public bool? IsCurrency { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public int RuneRarity { get; set; }
        public int ItemLevel { get; set; }
        public string ImagePath { get; set; }
    }
}
