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
    public class BuildingsController : ControllerBase
    {

        private readonly IBuildingService _BuildingService;
        public BuildingsController(IBuildingService BuildingService)
        {
            _BuildingService = BuildingService;
        }


        // GET: api/Buildings
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_BuildingService.List());
        }


        // POST: api/Buildings
        [HttpPost]
        public IActionResult Post([FromBody] BuildingDTO model)
        {
            _BuildingService.Insert(model);
            return Ok();
        }

        // PUT: api/Buildings/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BuildingDTO model)
        {
            model.ID = id;
            _BuildingService.Update(model);
            return Ok();
        }

        // DELETE: api/Buildings/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _BuildingService.DeleteEntity(id);
            return Ok();
        }
    }
}