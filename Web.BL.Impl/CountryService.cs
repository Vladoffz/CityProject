using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.BL.Abstract;
using Web.DAL.Impl;
using Web.DAL.Impl.Mappers;
using Web.Models;

namespace Web.BL.Impl
{
    public class  CountryService : CountryRepository, ICountryService
    {
        public CountryService(WebContext context) : base(context)
        {

        }
        public List<CountryDTO> List()
        {
            return this.ListEntities().Select(obj => CountryMapper.Map(obj)).ToList();
        }

        public void Insert(CountryDTO model)
        {
            this.InsertEntity(CountryMapper.DeMap(model));
        }

        public void Update(CountryDTO model)
        {
            this.UpdateEntity(CountryMapper.DeMap(model));
        }
    }
}
