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
    public class StreetService : StreetRepository, IStreetService
    {
        public StreetService(WebContext context) : base(context)
        {

        }
        public List<StreetDTO> List()
        {
            return this.ListEntities().Select(obj => StreetMapper.Map(obj)).ToList();
        }

        public void Insert(StreetDTO model)
        {
            this.InsertEntity(StreetMapper.DeMap(model));
        }

        public void Update(StreetDTO model)
        {
            this.UpdateEntity(StreetMapper.DeMap(model));
        }
    }
}
