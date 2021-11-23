using System;
using System.Collections.Generic;
using System.Text;
using Web.Entities;
using Web.Models;

namespace Web.DAL.Impl.Mappers
{
    public static class ResidentMapper
    {
        public static ResidentDTO Map(Resident entity)
        {
            return new ResidentDTO()
            {
                ID = entity.ID,
                FullName = entity.FullName,
                DateOfBirth = entity.DateOfBirth
            };
        }
        public static Resident DeMap(ResidentDTO model)
        {
            return new Resident()
            {
                ID = model.ID,
                FullName = model.FullName,
                DateOfBirth = model.DateOfBirth
            };
        }
    }
}
