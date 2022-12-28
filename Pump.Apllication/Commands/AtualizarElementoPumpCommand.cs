using MediatR;

namespace Pump.Apllication.Commands
{
    public class AtualizarElementoPumpCommand : IRequest<bool>
    {
        public AtualizarElementoPumpCommand(int id, string nome, decimal valor, decimal gramas)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Gramas = gramas;           
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal Gramas { get; set; }
    }
}