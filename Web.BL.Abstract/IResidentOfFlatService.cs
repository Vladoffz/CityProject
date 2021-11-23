using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;
using Web.Models;

namespace Web.BL.Abstract
{
    public interface IResidentOfFlatService : IResidentOfFlatRepository, IGenericService<ResidentOfFlatDTO>
    {
        public ResidentOfFlatDTO Get(int ID);
    }
}
