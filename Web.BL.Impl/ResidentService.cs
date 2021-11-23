using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using Web.BL.Abstract;
using Web.DAL.Impl;
using Web.DAL.Impl.Mappers;
using Web.Entities;
using Web.Models;

namespace Web.BL.Impl
{
    public class ResidentService : ResidentRepository, IResidentService
    {
        public ResidentService(WebContext context) : base(context)
        {

        }

        public List<ResidentDTO> List()
        {
            return this.ListEntities().Select(obj => ResidentMapper.Map(obj)).ToList();
        }

        public void Insert(ResidentDTO model)
        {
            this.InsertEntity(ResidentMapper.DeMap(model));
        }

        public void Update(ResidentDTO model)
        {
            this.UpdateEntity(ResidentMapper.DeMap(model));
        }

        public List<ResidentDTO> FindByFullName(string FullName)
        {
            return this.FindEntityByFullName(FullName).Select(obj => ResidentMapper.Map(obj)).ToList();
        }
        public List<ResidentDTO> FindByDateOfBirth(DateTime DateOfBirth)
        {
            return this.FindEntityByDateOfBirth(DateOfBirth).Select(obj => ResidentMapper.Map(obj)).ToList();
        }


    }
}
