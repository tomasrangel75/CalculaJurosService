using FluentValidation;

namespace CalculaJurosService.Service
{
    public abstract class BaseService
    {
        protected void ValidateDomain<TDomain, TValidate>(TDomain domain)
            where TValidate : AbstractValidator<TDomain>, new()
        {
            new TValidate().ValidateAndThrow(domain);
        }

    }
}