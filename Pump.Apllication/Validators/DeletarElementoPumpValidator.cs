using FluentValidation;
using Pump.Apllication.Commands;
using Pump.Domain.Interfaces;

namespace Pump.Apllication.Validators
{
    public class DeletarElementoPumpValidator : AbstractValidator<DeletarElementoPumpCommand>
    {        
        /// <summary>
        /// Validar antes de Deletar verificando se o Id e Null(NotNull) e Maior que 0 (GreaterThan(0)) 
        /// Must aplica sua propria condição (Must(id => _repository.GetElementoId(id) != null))
        /// </summary>
        /// <param name="_repository"></param>
        public DeletarElementoPumpValidator(IRepository _repository)
        {           
            RuleFor(x => x.Id).NotNull().GreaterThan(0);
            // RuleFor(x => x.Id).NotNull().GreaterThan(0).Must(id => _repository.GetElementoId(id) != null);
        }
    }
}