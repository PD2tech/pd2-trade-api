using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.Abstracts;

namespace Pd2TradeApi.Server.Models.DTOs.Item.Request
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
        public string SubCategory { get; set; }
        public int RuneRarity { get; set; }
        public int ItemLevel { get; set; }
        public string ImagePath { get; set; }
        public long TotalSockets { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool Corrupted { get; set; }
    }
}
