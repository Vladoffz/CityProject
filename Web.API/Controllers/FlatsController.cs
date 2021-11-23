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
    public class FlatsController : ControllerBase
    {

        private readonly IFlatService _FlatService;
        public FlatsController(IFlatService FlatService)
        {
            _FlatService = FlatService;
        }


        // GET: api/Residents
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_FlatService.List());
        }


        // POST: api/Residents
        [HttpPost]
        public IActionResult Post([FromBody] FlatDTO model)
        {
            _FlatService.Insert(model);
            return Ok();
        }

        // PUT: api/Residents/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FlatDTO model)
        {
            model.ID = id;
            _FlatService.Update(model);
            return Ok();
        }

        // DELETE: api/Residents/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _FlatService.DeleteEntity(id);
            return Ok();
        }
    }
}