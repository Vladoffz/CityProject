using System;
using System.Collections.Generic;
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
    public class ResidentsController : ControllerBase
    {

        private readonly IResidentService _ResidentService;
        public ResidentsController(IResidentService ResidentService)
        {
            _ResidentService = ResidentService;
        }


        // GET: api/Residents
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ResidentService.List());
        }


        // POST: api/Residents
        [HttpPost]
        public IActionResult Post([FromBody] ResidentDTO model)
        {
            _ResidentService.Insert(model);
            return Ok();
        }

        // PUT: api/Residents/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ResidentDTO model)
        {
            model.ID = id;
            _ResidentService.Update(model);
            return Ok();
        }

        // DELETE: api/Residents/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _ResidentService.DeleteEntity(id);
            return Ok();
        }
    }
}
