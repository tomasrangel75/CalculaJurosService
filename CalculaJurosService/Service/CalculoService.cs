using CalculaJurosService.Infrastructure.DataTransferObjects;
using CalculaJurosService.Infrastructure.Enums;
using CalculaJurosService.Model;
using CalculaJurosService.Model.DTOs;
using CalculaJurosService.Validators;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJurosService.Service
{
    public class CalculoService : BaseService, ICalculoService
    {
        public ObjectReplyDTO<object> CalculaJuros(CalculoValuesDto calcValues)
        {
            var validator = new CalculoValuesDtoValidator();
            var results = validator.Validate(calcValues);

            if (!results.IsValid)
            {
                var validatorResult = new ObjectReplyDTO<object>();
                foreach (var failure in results.Errors)
                {
                    validatorResult.StatusReplyCode = ObjectReplyEnum.BusinessError;
                    string msg = $"Propriedade : {failure.PropertyName} => Erro: {failure.ErrorMessage}";
                    validatorResult.Message += msg;
                }
                return validatorResult;
            }

            return CalculoJurosCompostos(calcValues);
        }

        private ObjectReplyDTO<object> CalculoJurosCompostos(CalculoValuesDto calcValues)
        {
            var result = new ObjectReplyDTO<object>();

            try
            {
                var financiamento = new Financiamento
                {
                    Juros = Convert.ToDouble(GetJuros().Result),
                    Periodo = calcValues.Periodo,
                    ValorInicial = calcValues.ValorInicial
                };

                var valorTotal = financiamento.GetValorFinal();
                result.Message = $"Valor final para um periodo de {calcValues.Periodo} meses.";
                result.ObjectReplyEntity = valorTotal;
                result.StatusReplyCode = ObjectReplyEnum.Success;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.ObjectReplyEntity = null;
                result.StatusReplyCode = ObjectReplyEnum.BusinessError;
            }

            return result;
        }

        private async Task<string> GetJuros()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://host.docker.internal:59432/Juros");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception("Taxa de juros inacessível!");
                }
            }

        }
    }
}
