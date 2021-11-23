using System;
using System.Collections.Generic;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.BL.Abstract
{
    public interface IPopulationService
    {
        public List<ResidentDTO> FindResidentsByNumberOfApartments(int NumberOfApartments);
        public List<CityDTO> FindCitiesByNumberOfResidents(int NumberOfResidents);

    }
}
