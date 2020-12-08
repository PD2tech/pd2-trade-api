using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.Abstracts;

namespace Pd2TradeApi.Server.Models.DTOs.Item.Request
{
    public class ItemFilter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? StrengthRequirement { get; set; }
        public int? DexterityRequirement { get; set; }
        public int? LevelRequirement { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public int RuneRarity { get; set; }
        public int ItemLevel { get; set; }
        public long TotalSockets { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool Corrupted { get; set; }
        public int Defence { get; set; }
    }
}
