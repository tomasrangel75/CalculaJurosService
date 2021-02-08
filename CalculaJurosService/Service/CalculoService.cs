using CalculaJurosService.Infrastructure.DataTransferObjects;
using CalculaJurosService.Infrastructure.Enums;
using CalculaJurosService.Model.DTOs;
using CalculaJurosService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using CalculaJurosService.Validators;
using CalculaJurosService.Model;

namespace CalculaJurosService.Service
{
    public class CalculoService : BaseService, ICalculoService
    {
        public ObjectReplyDTO<object> CalculaJuros(CalculoValuesDto calcValues)
        {
            ValidateDomain<CalculoValuesDto, CalculoValuesDtoValidator>(calcValues);
            return CalculoJurosCompostos(calcValues);
        }

        private ObjectReplyDTO<object> CalculoJurosCompostos(CalculoValuesDto calcValues)
        {
            var result = new ObjectReplyDTO<object>();
            var financiamento = new Financiamento
            {
                Juros = GetJuros(),
                Periodo = calcValues.Periodo,
                ValorInicial = calcValues.ValorInicial
            };

            try
            {
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

        private double GetJuros()
        {
            return 0.01;
        }
    }
}
