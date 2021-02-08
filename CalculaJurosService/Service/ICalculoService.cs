using CalculaJurosService.Infrastructure.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosService.Service
{
    public interface ICalculoService
    {
        ObjectReplyDTO<object> CalculaJuros(Model.DTOs.CalculoValuesDto calcValues);
    }
}
