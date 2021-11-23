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
    public class ResidentOfFlatService : ResidentOfFlatRepository, IResidentOfFlatService
    {
        public ResidentOfFlatService(WebContext context) : base(context)
        {

        }

        public List<ResidentOfFlatDTO> List()
        {
            return this.ListEntities().Select(obj => ResidentOfFlatMapper.Map(obj)).ToList();
        }

        public void Insert(ResidentOfFlatDTO _ResidentOfFlat)
        {
            this.InsertEntity(ResidentOfFlatMapper.DeMap(_ResidentOfFlat));
        }

        public ResidentOfFlatDTO Get(int ID)
        {
            return ResidentOfFlatMapper.Map(this.GetEntity(ID));
        }

        public void Update(ResidentOfFlatDTO model)
        {
            this.UpdateEntity(ResidentOfFlatMapper.DeMap(model));
        }
    }
}
