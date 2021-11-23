using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;

namespace Web.DAL.Impl
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(WebContext context) : base(context)
        {

        }
        public IEnumerable<City> FindEntityByName(string Name)
        {
            return this.ListEntities().Where(obj => obj.Name.Contains(Name));
        }

        public IEnumerable<City> GetListDownToTheRoot()
        {
            return this._dataContext.Set<City>().Include(obj => obj.Streets).ThenInclude(obj2 => obj2.Buildings).ThenInclude(obj3 => obj3.Flats).ToList();
        }

    }

}
