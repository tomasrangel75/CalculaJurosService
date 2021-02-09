using CalculaJurosService.Infrastructure.DataTransferObjects;
using CalculaJurosService.Model.DTOs;
using CalculaJurosService.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculaJurosService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : BaseController
    {
        private readonly ILogger<CalculaJurosController> _logger;
        private readonly ICalculoService _calculo;

        public CalculaJurosController(ICalculoService calculo)
        {
            _calculo = calculo;
        }

        [HttpGet]
        public ObjectReplyDTO<object> Get([FromQuery] CalculoValuesDto calcValues)
        {
            var result = _calculo.CalculaJuros(calcValues);
            return result;
        }

    }
}
