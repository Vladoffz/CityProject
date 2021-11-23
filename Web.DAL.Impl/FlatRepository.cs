using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;

namespace Web.DAL.Impl
{

    public class FlatRepository : GenericRepository<Flat>, IFlatRepository
    {
        public FlatRepository(WebContext context) : base(context)
        {

        }
    }
}
