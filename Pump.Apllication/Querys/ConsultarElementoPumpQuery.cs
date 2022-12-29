using MediatR;
using Pump.Domain.Entity;

namespace Pump.Apllication.Querys
{
    public class ConsultarElementoPumpQuery : IRequest<ElementoPumpEntity>
    {
        public ConsultarElementoPumpQuery(int id)
        {
            this.id = id;
        }

        public int id {get;set;}
    }
}