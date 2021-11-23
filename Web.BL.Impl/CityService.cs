using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.BL.Abstract;
using Web.DAL.Impl;
using Web.DAL.Impl.Mappers;
using Web.Models;

namespace Web.BL.Impl
{
    public class CityService : CityRepository, ICityService
    {
        public CityService(WebContext context) : base(context)
        {

        }

        public List<CityDTO> List()
        {
            return this.ListEntities().Select(obj => CityMapper.Map(obj)).ToList();
        }

        public void Insert(CityDTO model)
        {
            this.InsertEntity(CityMapper.DeMap(model));
        }

        public void Update(CityDTO model)
        {
            this.UpdateEntity(CityMapper.DeMap(model));
        }

        public List<CityDTO> FindByName(string Name)
        {
            return this.FindEntityByName(Name).Select(obj => CityMapper.Map(obj)).ToList();
        }

    }
}
