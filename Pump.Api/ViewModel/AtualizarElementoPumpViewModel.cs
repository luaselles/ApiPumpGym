using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pump.Api.ViewModel
{
    public class AtualizarElementoPumpViewModel
    {
        public AtualizarElementoPumpViewModel(string nome, decimal valor, decimal gramas)
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