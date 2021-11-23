using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class Street
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CityID { get; set; }
        [ForeignKey(nameof(CityID))]
        public City City { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }
}
