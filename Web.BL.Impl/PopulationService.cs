using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Web.BL.Abstract;
using Web.DAL.Abstract;
using Web.DAL.Impl.Mappers;
using Web.Entities;
using Web.Models;

namespace Web.BL.Impl
{
    public class PopulationService : IPopulationService
    {
        private readonly IResidentRepository _ResidentRepository;
        private readonly IResidentOfFlatRepository _ResidentOfFlatRepository;
        private readonly ICityRepository _CityRepository;

        public PopulationService(IResidentRepository ResidentRepository, IResidentOfFlatRepository ResidentOfFlatRepository, ICityRepository CityRepository)
        {
            _ResidentRepository = ResidentRepository;
            _ResidentOfFlatRepository = ResidentOfFlatRepository;
            _CityRepository = CityRepository;
        }

        public List<ResidentDTO> FindResidentsByNumberOfApartments(int NumberOfApartments)
        {
            List<Resident> Residents = new List<Resident>();
            foreach (Resident R in _ResidentRepository.ListEntities())
            {
                if(_ResidentOfFlatRepository.ListEntities(obj => obj.ResidentID == R.ID).Count() == NumberOfApartments) { Residents.Add(R); }
            }
            return Residents.Select(obj => ResidentMapper.Map(obj)).ToList();
        }
        public List<CityDTO> FindCitiesByNumberOfResidents(int NumberOfResidents)
        {
            List<City> Cities = new List<City>();

            foreach (City C in _CityRepository.GetListDownToTheRoot())
            {
                int NumberOfResidentsInCurrentCity = 0;
                foreach (Street S in C.Streets)
                {
                    foreach (Building B in S.Buildings)
                    {
                        foreach (Flat F in B.Flats)
                        {
                            NumberOfResidentsInCurrentCity += _ResidentOfFlatRepository.ListEntities().Where(obj => obj.FlatID == F.ID).Count();
                        }
                    }
                }
                if (NumberOfResidentsInCurrentCity== NumberOfResidents)
                {
                    Cities.Add(C);
                }
            }
            return Cities.Select(obj => CityMapper.Map(obj)).ToList();
        }
    }
}
