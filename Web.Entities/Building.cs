using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class Building 
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Coordinates { get; set; }
        [Required]
        public int StreetID { get; set; }
        [ForeignKey(nameof(StreetID))]
        public Street Street { get; set; }
        public virtual ICollection<Flat> Flats { get; set; }
    }
}
