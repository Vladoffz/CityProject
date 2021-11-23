using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class ResidentOfFlat
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int ResidentID { get; set; }
        [Required]
        public int FlatID { get; set; }
        [ForeignKey(nameof(ResidentID))]
        public Resident Resident { get; set; }
        [ForeignKey(nameof(ResidentID))]
        public Flat Flat { get; set; }
    }
}
