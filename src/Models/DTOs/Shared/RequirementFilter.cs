using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Models.DTOs.Shared
{
    public class RequirementFilter
    {
        public string Requirement {get; set;}
        public float Min {get; set;}
        public float Max {get; set;}
    }
}
