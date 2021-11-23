using System;
using System.Collections.Generic;
using System.Text;
using Web.Entities;

namespace Web.DAL.Abstract
{
    public interface IResidentRepository : IGenericRepository<Resident>
    {
        public IEnumerable<Resident> FindEntityByFullName(string FullName);
        public IEnumerable<Resident> FindEntityByDateOfBirth(DateTime DateOfBirth);
    }
}
