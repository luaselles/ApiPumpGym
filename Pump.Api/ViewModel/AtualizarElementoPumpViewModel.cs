using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pump.Api.ViewModel
{
    public class AtualizarElementoPumpViewModel
    {
        public AtualizarElementoPumpViewModel(int id, string nome, decimal valor, decimal gramas)
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