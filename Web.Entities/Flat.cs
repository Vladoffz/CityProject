using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class Flat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        [Range(9, 999999)]
        public int Square { get; set; }
        [Required]
        public int BuildingID { get; set; }
        [ForeignKey(nameof(BuildingID))]
        public Building Building { get; set; }
    }
}
