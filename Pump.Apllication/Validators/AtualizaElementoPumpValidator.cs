using FluentValidation;
using Pump.Apllication.Commands;
using Pump.Domain.Interfaces;

namespace Pump.Apllication.Validators
{
    /// <summary>
    /// 
    /// </summary>
    public class AtualizaElementoPumpValidator : AbstractValidator<AtualizarElementoPumpCommand>
    {
        private readonly IRepository _repository;
        public AtualizaElementoPumpValidator(IRepository repository)
        {
            RuleFor(x => x.Id).Must(ValidateId);
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(120).NotEmpty();
            RuleFor(x => x.Valor).NotNull().NotEmpty();
             _repository = repository;
        }
        private bool ValidateId (int Id)
        {
            if (_repository.GetAnyId(Id))
            {
                return true;
            }
            return false;
            
        }
    }
}