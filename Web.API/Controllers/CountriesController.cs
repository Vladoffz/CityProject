using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.BL.Abstract;
using Web.DAL.Impl;
using Web.Models;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CountriesController : ControllerBase
    {

        private readonly ICountryService _CountryService;
        public CountriesController(ICountryService CountryService)
        {
            _CountryService = CountryService;
        }


        // GET: api/Countries
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_CountryService.List());
        }


        // POST: api/Countries
        [HttpPost]
        public IActionResult Post([FromBody] CountryDTO model)
        {
            _CountryService.Insert(model);
            return Ok();
        }

        // PUT: api/Countries/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CountryDTO model)
        {
            model.ID = id;
            _CountryService.Update(model);
            return Ok();
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _CountryService.DeleteEntity(id);
            return Ok();
        }
    }
}