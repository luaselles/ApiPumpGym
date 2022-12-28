using MediatR;
using Pump.Domain.Entity;

namespace Pump.Apllication.Notifications
{
    public class ElementoPumpCadastradoNotification : INotification
    {
        public ElementoPumpCadastradoNotification(ElementoPumpEntity elementoPump)
        {
            this.elementoPump = elementoPump;
        }

        public ElementoPumpEntity elementoPump {get; private set;}
    }
}