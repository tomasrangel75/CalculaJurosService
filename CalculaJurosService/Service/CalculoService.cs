using CalculaJurosService.Infrastructure.DataTransferObjects;
using CalculaJurosService.Infrastructure.Enums;
using CalculaJurosService.Model.DTOs;
using CalculaJurosService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculaJurosService.Service
{
    public class CalculoService : BaseService, ICalculoService
    {
        public ObjectReplyDTO<object> CalculaJuros(CalculoValuesDto calcValues)
        {
            //this.ValidateDomain<AuthenticationDTO, AuthenticationValidator>(authenticationDTO);
            return CalculoJurosCompostos(calcValues);
        }

        private ObjectReplyDTO<object> CalculoJurosCompostos(CalculoValuesDto calcValues)
        {
            var result = new ObjectReplyDTO<object>();
            var valIni = calcValues.ValorInicial;
            var m = calcValues.Periodo;
            double j = 0.01f; // juros

            try
            {
                var parc = valIni * (Math.Pow((1 + j), m) * j) / (Math.Pow((1 + j), m) - 1);
                var valTotal = Math.Round((parc * m), 2);

                result.Message = $"Valor final para um periodo de {calcValues.Periodo} meses.";
                result.ObjectReplyEntity = valTotal;
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
       
    }
}
