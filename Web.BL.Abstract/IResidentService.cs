using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Abstract;
using Web.Models;

namespace Web.BL.Abstract
{
    public interface IResidentService : IResidentRepository, IGenericService<ResidentDTO>
    {
        public List<ResidentDTO> FindByFullName(string FullName);
        public List<ResidentDTO> FindByDateOfBirth(DateTime DateOfBirth);

    }
}
