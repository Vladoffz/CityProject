using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;
using System.Linq;

namespace Web.DAL.Impl
{

    public class ResidentOfFlatRepository : GenericRepository<ResidentOfFlat>, IResidentOfFlatRepository
    {
        public ResidentOfFlatRepository(WebContext context) : base(context)
        {

        }

    }
}
