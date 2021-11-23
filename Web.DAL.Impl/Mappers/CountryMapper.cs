using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.DAL.Impl.Mappers
{
    public static class CountryMapper
    {
        public static CountryDTO Map(Country entity)
        {
            return new CountryDTO()
            {
                ID = entity.ID,
                Name = entity.Name,
/*                Cities = entity.Cities.Select(obj => CityMapper.Map(obj)).ToList()*/
            };
        }
        public static Country DeMap(CountryDTO model)
        {
            return new Country()
            {
                ID = model.ID,
                Name = model.Name
            };
        }
    }
}
