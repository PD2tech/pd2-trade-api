using Pd2TradeApi.Server.Models.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pd2TradeApi.Server.Models.DatabaseModels
{
    [Table("Season")]
    public class Season : BaseEntity
    {
        public string Name {get; set;}
        public int? Number {get; set;}
    }
}
