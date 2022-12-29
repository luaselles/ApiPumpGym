using MediatR;
using Pump.Domain.Entity;

namespace Pump.Apllication.Notifications
{
    public class ElementoPumpConsultadoNotification : INotification
    {
        public ElementoPumpConsultadoNotification(ElementoPumpEntity elementoPump)
        {
            this.elementoPump = elementoPump;
        }

        public ElementoPumpEntity elementoPump { get; private set; }
    }
}