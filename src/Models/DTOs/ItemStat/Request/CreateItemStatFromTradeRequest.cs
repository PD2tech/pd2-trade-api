﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Models.DTOs.ItemStat.Request
{
    public class CreateItemStatRequest
    {
        public long? Id {get; set;}
        public string Code { get; set; }
        public string Name {get; set;}
        public string Skill { get; set; }
        public string DisplayName {get; set;}
        public float MinValue {get; set;}
        public float MaxValue {get; set;}
    }
}
