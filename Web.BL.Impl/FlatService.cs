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
    public class FlatService : FlatRepository, IFlatService
    {
        public FlatService(WebContext context) : base(context)
        {

        }
        public List<FlatDTO> List()
        {
            return this.ListEntities().Select(obj => FlatMapper.Map(obj)).ToList();
        }

        public void Insert(FlatDTO model)
        {
            this.InsertEntity(FlatMapper.DeMap(model));
        }

        public void Update(FlatDTO model)
        {
            this.UpdateEntity(FlatMapper.DeMap(model));
        }
    }
}
