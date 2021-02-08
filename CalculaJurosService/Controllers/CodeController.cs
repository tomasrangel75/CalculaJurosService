using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosService.Controllers
{
    [Route("/showmethecode")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Redirect("https://github.com/tomasrangel75/CalculaJurosService");
        }

    }
}
