using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models
{
    public class CountryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<CityDTO> Cities { get; set; }
    }
}
