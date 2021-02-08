using CalculaJurosService.Infrastructure.DataTransferObjects;
using CalculaJurosService.Infrastructure.Enums;
using CalculaJurosService.Model.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : BaseController
    {
        private readonly ILogger<CalculaJurosController> _logger;

        // GET api/<CalculoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CalculoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CalculoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CalculoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
