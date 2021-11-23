using System;
using System.Collections.Generic;
using System.Text;
using Web.Entities;

namespace Web.DAL.Abstract
{
    public interface ICityRepository : IGenericRepository<City>
    {
        public IEnumerable<City> FindEntityByName(string Name);
        public IEnumerable<City> GetListDownToTheRoot();
    }
}
