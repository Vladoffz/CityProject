using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;

namespace Web.DAL.Impl
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(WebContext context) : base(context)
        {

        }
    }
}
