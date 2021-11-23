using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.DAL.Impl.Mappers
{
    public static class BuildingMapper
    {
        public static BuildingDTO Map(Building entity)
        {
            return new BuildingDTO()
            {
                ID = entity.ID,
                Number = entity.Number,
                Coordinates = entity.Coordinates,
                StreetID = entity.StreetID,
/*                Street = StreetMapper.Map(entity.Street),
                Flats = entity.Flats.Select(obj => FlatMapper.Map(obj)).ToList()*/
            };
        }
        public static Building DeMap(BuildingDTO model)
        {
            return new Building()
            {
                ID = model.ID,
                Number = model.Number,
                Coordinates = model.Coordinates,
                StreetID = model.StreetID
            };

        }
    }
}
