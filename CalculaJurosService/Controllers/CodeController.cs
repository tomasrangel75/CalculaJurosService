using Microsoft.AspNetCore.Mvc;

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
