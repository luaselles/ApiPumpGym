
using MediatR;

namespace Pump.Apllication.Commands
{
    public class CadastrarElementoPumpCommand : IRequest<bool>
    {
        public CadastrarElementoPumpCommand(string nome, decimal valor, decimal gramas)
        {
            Nome = nome;
            Valor = valor;
            Gramas = gramas;
        }

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal Gramas { get; set; }
    }
}