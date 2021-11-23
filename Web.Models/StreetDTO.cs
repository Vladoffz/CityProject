using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models
{
    public class StreetDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }
        public CityDTO City { get; set; }
        public List<BuildingDTO> Buildings { get; set; }
    }
}
