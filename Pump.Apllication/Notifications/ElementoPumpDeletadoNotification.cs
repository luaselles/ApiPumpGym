using MediatR;
using Pump.Domain.Entity;

namespace Pump.Apllication.Notifications
{
    public class ElementoPumpDeletadoNotification : INotification
    {
        public ElementoPumpDeletadoNotification(ElementoPumpEntity elementoPump)
        {
            this.elementoPump = elementoPump;
        }

        public ElementoPumpEntity elementoPump {get; private set;}
    }
}