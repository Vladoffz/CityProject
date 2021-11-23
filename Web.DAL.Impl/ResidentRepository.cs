using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;

namespace Web.DAL.Impl
{
    public class ResidentRepository : GenericRepository<Resident>, IResidentRepository
    {
        public ResidentRepository(WebContext context) : base(context)
        {

        }

        public IEnumerable<Resident> FindEntityByFullName(string FullName)
        {
            return this.ListEntities().Where(obj => obj.FullName.Contains(FullName));
        }
        public IEnumerable<Resident> FindEntityByDateOfBirth(DateTime DateOfBirth)
        {
            return this.ListEntities().Where(obj => obj.DateOfBirth.Equals(DateOfBirth));
        }
    }
}
