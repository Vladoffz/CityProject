using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CountryID { get; set; }
        [ForeignKey(nameof(CountryID))]
        public Country Country { get; set; }

        public virtual ICollection<Street> Streets { get; set; }
    }
}