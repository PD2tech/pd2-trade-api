﻿using Pd2TradeApi.Server.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("ItemStat")]
    public class ItemStat : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public string DisplayName { get; set; }
        public float? MinValue { get; set; }
        public float? MaxValue { get; set; }
        public List<ItemItemStat> Items { get; set; }
        public List<Runeword> Runewords { get; set; }
        public List<ItemStatTradeOffer> TradeOffers { get; set; }
    }
}
