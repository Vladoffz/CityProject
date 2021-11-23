using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models
{
    public class CityDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CountryID { get; set; }
        public CountryDTO Country { get; set; }
        public List<StreetDTO> Streets { get; set; }
    }
}
