using System;
using System.Collections.Generic;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.DAL.Impl.Mappers
{
    public static class ResidentOfFlatMapper
    {
        public static ResidentOfFlatDTO Map(ResidentOfFlat entity)
        {
            return new ResidentOfFlatDTO()
            {
                ID = entity.ID,
                ResidentID = entity.ResidentID,
                FlatID = entity.FlatID,
/*                Resident = ResidentMapper.Map(entity.Resident),
                Flat = FlatMapper.Map(entity.Flat)*/
            };
        }
        public static ResidentOfFlat DeMap(ResidentOfFlatDTO model)
        {
            return new ResidentOfFlat()
            {
                ID = model.ID,
                ResidentID = model.ResidentID,
                FlatID = model.FlatID
            };
        }
    }
}
