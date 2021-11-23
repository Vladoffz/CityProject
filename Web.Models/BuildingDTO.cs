using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models
{
    public class BuildingDTO
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public string Coordinates { get; set; }
        public int StreetID { get; set; }
        public StreetDTO Street { get; set; }
        public List<FlatDTO> Flats { get; set; }
    }
}
