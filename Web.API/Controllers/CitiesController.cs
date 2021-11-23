using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.BL.Abstract;
using Web.Models;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CitiesController : ControllerBase
    {

        private readonly ICityService _CityService;
        public CitiesController(ICityService CityService)
        {
            _CityService = CityService;
        }


        // GET: api/Cities
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_CityService.List());
        }


        // POST: api/Cities
        [HttpPost]
        public IActionResult Post([FromBody] CityDTO model)
        {
            _CityService.Insert(model);
            return Ok();
        }

        // PUT: api/Cities/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CityDTO model)
        {
            model.ID = id;
            _CityService.Update(model);
            return Ok();
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _CityService.DeleteEntity(id);
            return Ok();
        }
    }
}