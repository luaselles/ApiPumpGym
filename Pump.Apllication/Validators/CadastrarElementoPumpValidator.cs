using FluentValidation;
using Pump.Apllication.Commands;

namespace Pump.Apllication.Validators
{
    public class CadastrarElementoPumpValidator : AbstractValidator<CadastrarElementoPumpCommand>
    {
        /// <summary>
        /// Validar antes de Cadastrar o elemento se o 'Nome' e NotEmpty() 
        /// se nâo excede o maximo de caracteres se o 'Valor' e diferente de null
        /// se as gramas são diferentes de Null
        /// </summary>
        public CadastrarElementoPumpValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().MaximumLength(120);
            RuleFor(x => x.Valor).NotNull().NotEmpty();
            RuleFor(x => x.Gramas).NotNull().NotEmpty();
        }
    }
}