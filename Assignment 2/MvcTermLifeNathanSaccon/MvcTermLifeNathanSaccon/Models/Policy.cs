using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcTermLifeNathanSaccon.Models
{
    public class Policy
    {
        [Required]
        [Range(10000, 1000000)]
        public decimal? Amount { get; set; }
    }
}
