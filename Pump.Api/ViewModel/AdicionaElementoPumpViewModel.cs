
namespace Pump.Api.ViewModel
{
    public class AdicionaElementoPumpViewModel
    {
        public AdicionaElementoPumpViewModel(string nome, decimal valor, decimal gramas)
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