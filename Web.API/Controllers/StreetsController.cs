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
    public class StreetsController : ControllerBase
    {
        private readonly IStreetService _StreetService;
        public StreetsController(IStreetService StreetService)
        {
            _StreetService = StreetService;
        }


        // GET: api/Streets
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_StreetService.List());
        }


        // POST: api/Streets
        [HttpPost]
        public IActionResult Post([FromBody] StreetDTO model)
        {
            _StreetService.Insert(model);
            return Ok();
        }

        // PUT: api/Streets/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] StreetDTO model)
        {
            model.ID = id;
            _StreetService.Update(model);
            return Ok();
        }

        // DELETE: api/Streets/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _StreetService.DeleteEntity(id);
            return Ok();
        }
    }
}