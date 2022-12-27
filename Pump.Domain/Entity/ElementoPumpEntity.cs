namespace Pump.Domain.Entity
{
    public class ElementoPumpEntity
    {
        public ElementoPumpEntity(string nome, decimal valor, decimal gramas)
        {
            Nome = nome;
            Valor = valor;
            Gramas = gramas;
        }

        public int Id {get; set;}
        public string Nome {get; set;}
        public decimal Valor {get; set;}
        public decimal Gramas {get; set;}
        
    }
}