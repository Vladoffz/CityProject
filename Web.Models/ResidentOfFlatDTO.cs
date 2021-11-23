using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models
{
    public class ResidentOfFlatDTO
    {
        public int ID { get; set; }
        public int ResidentID { get; set; }
        public int FlatID { get; set; }
        public ResidentDTO Resident { get; set; }
        public FlatDTO Flat { get; set; }
    }
}
