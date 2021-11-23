using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.DAL.Impl.Mappers
{
    public static class StreetMapper
    {
        public static StreetDTO Map(Street entity)
        {
            return new StreetDTO()
            {
                ID = entity.ID,
                Name = entity.Name,
                CityID = entity.CityID,
/*                City = CityMapper.Map(entity.City),
                Buildings = entity.Buildings.Select(obj => BuildingMapper.Map(obj)).ToList()*/
            };
        }
        public static Street DeMap(StreetDTO model)
        {
            return new Street()
            {
                ID = model.ID,
                Name = model.Name,
                CityID = model.CityID
            };
        }
    }
}
