using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Models
{
    [Table("User")]
    public class User : IdentityUser<long>
    {
        public bool IsDeleted { get; set; }
        public string Password { get; set; }
        public string AccountName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<TradeOffer> Offers { get; set; }
    }
}
