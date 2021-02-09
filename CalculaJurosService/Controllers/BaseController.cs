using CalculaJurosService.Infrastructure.DataTransferObjects;
using CalculaJurosService.Infrastructure.Enums;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CalculaJurosService.Controllers
{
    public class BaseController : ControllerBase
    {
        protected TResult ProtectException<TResult>(Func<TResult> testeBody)
           where TResult : ObjectReplyDTO, new()
        {
            try
            {
                return testeBody();
            }
            catch (Exception ex)
            {
                return new TResult() { StatusReplyCode = ObjectReplyEnum.SystemError, Message = ex.Message };
            }
        }
    }
}
