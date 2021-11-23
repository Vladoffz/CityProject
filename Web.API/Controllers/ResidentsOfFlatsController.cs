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
    public class ResidentsOfFlatsController : ControllerBase
    {
   
        private readonly IResidentOfFlatService _ResidentOfFlatService;
        private readonly IValidationService _ValidationService;
        public ResidentsOfFlatsController(IResidentOfFlatService ResidentOfFlatService, IValidationService ValidationService)
        {
            _ResidentOfFlatService = ResidentOfFlatService;
            _ValidationService = ValidationService;
        }


        // GET: api/Residents
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ResidentOfFlatService.List());
        }


        // POST: api/Residents
        [HttpPost]
        public IActionResult Post([FromBody] ResidentOfFlatDTO model)
        {
            if (ModelState.IsValid && _ValidationService.VerifyPossibilityOfSettlement(model.FlatID))
            {
                _ResidentOfFlatService.Insert(model);
                return Ok();
            }
            return BadRequest();
        
        }

        // PUT: api/Residents/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ResidentOfFlatDTO model)
        {
            model.ID = id;
            _ResidentOfFlatService.Update(model);
            return Ok();
        }

        // DELETE: api/Residents/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _ResidentOfFlatService.DeleteEntity(id);
            return Ok();
        }
    }
}