using MediatR;
using Pump.Domain.Entity;

namespace Pump.Apllication.Notifications
{
    public class ElementoPumpAtualizadoNotification : INotification
    {
        public ElementoPumpAtualizadoNotification(ElementoPumpEntity elementoPump)
        {
            this.elementoPump = elementoPump;
        }

        public ElementoPumpEntity elementoPump {get; private set;}
    }
}