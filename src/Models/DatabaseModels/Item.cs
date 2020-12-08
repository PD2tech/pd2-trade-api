using Pd2TradeApi.Server.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("Item")]
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int? StrengthRequirement { get; set; }
        public int? DexterityRequirement { get; set; }
        public int? LevelRequirement { get; set; }
        public bool? IsCurrency { get; set; }
        public bool? IsSearchable { get; set; }
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
        public List<ItemStat> DefaultStats { get; set; }
        public List<ItemSocket> Sockets { get; set; }
        public long? RunewordId { get; set; }
        public Runeword Runeword { get; set; }
    }
}
