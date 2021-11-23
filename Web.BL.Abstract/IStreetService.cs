using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Abstract;
using Web.Models;

namespace Web.BL.Abstract
{
    public interface IStreetService : IStreetRepository, IGenericService<StreetDTO>
    {
    }
}
