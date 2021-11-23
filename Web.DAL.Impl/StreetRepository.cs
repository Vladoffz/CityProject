using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;

namespace Web.DAL.Impl
{
    public class StreetRepository : GenericRepository<Street>, IStreetRepository
    {
        public StreetRepository(WebContext context) : base(context)
        {

        }
    }
}
