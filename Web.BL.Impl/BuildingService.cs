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

    public class BuildingService : BuildingRepository, IBuildingService
    {
        public BuildingService(WebContext context) : base(context)
        {

        }
        public List<BuildingDTO> List()
        {
            return this.ListEntities().Select(obj => BuildingMapper.Map(obj)).ToList();
        }

        public void Insert(BuildingDTO model)
        {
            this.InsertEntity(BuildingMapper.DeMap(model));
        }

        public void Update(BuildingDTO model)
        {
            this.UpdateEntity(BuildingMapper.DeMap(model));
        }
    }
}
