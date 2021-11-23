using System;
using System.Collections.Generic;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.DAL.Impl.Mappers
{
    public static class FlatMapper
    {
        public static FlatDTO Map(Flat entity)
        {
            return new FlatDTO()
            {
                ID = entity.ID,
                Number = entity.Number,
                Square = entity.Square,
/*                BuildingID = entity.BuildingID,
                Building = BuildingMapper.Map(entity.Building)*/
            };
        }

        public static Flat DeMap(FlatDTO model)
        {
            return new Flat()
            {
                ID = model.ID,
                Number = model.Number,
                Square = model.Square
            };

        }
    }
}
