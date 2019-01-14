using System.ComponentModel.DataAnnotations;

namespace MvcTermLifeNathanSaccon.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(20, 69)]
       
        public int? Age { get; set; }
    }
}
