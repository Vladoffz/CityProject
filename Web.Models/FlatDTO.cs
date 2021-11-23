using System;

namespace Web.Models
{
    public class FlatDTO
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int Square { get; set; }
        public int BuildingID { get; set; }
        public BuildingDTO Building { get; set; }
    }
}
