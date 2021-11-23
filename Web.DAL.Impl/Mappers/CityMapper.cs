using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.DAL.Impl.Mappers
{
    public static class CityMapper
    {
        public static CityDTO Map(City entity)
        {
            return new CityDTO()
            {
                ID = entity.ID,
                Name = entity.Name,
                CountryID = entity.CountryID,
/*                Country = CountryMapper.Map(entity.Country),
                Streets = entity.Streets.Select(obj => StreetMapper.Map(obj)).ToList()*/
            };
        }
        public static City DeMap(CityDTO model)
        {
            return new City()
            {
                ID = model.ID,
                Name = model.Name,
                CountryID = model.CountryID
            };
        }
    }
}
