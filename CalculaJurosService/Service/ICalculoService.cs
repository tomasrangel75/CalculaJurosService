using CalculaJurosService.Infrastructure.DataTransferObjects;

namespace CalculaJurosService.Service
{
    public interface ICalculoService
    {
        ObjectReplyDTO<object> CalculaJuros(Model.DTOs.CalculoValuesDto calcValues);
    }
}
