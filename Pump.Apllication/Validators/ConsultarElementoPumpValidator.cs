using FluentValidation;
using Pump.Apllication.Querys;
using Pump.Domain.Interfaces;

namespace Pump.Apllication.Validators
{
    public class ConsultarElementoPumpValidator : AbstractValidator<ConsultarElementoPumpQuery>
    {
        public ConsultarElementoPumpValidator(IRepository _repository)
        {
            
        }
    }
}