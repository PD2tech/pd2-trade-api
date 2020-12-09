﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("ItemItemStat")]
    public class ItemItemStat
    {
        public long ItemId {get; set;}
        public Item Item {get; set;}
        public long ItemStatId {get; set;}
        public ItemStat ItemStat {get; set;}
    }
}
