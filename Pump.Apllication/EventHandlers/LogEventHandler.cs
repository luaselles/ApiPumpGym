using MediatR;
using Pump.Apllication.Notifications;
using Microsoft.Extensions.Logging;
namespace Pump.Apllication.EventHandlers
{
    public class LogEventHandler : INotificationHandler<ElementoPumpCadastradoNotification>
    {
        private readonly ILogger<LogEventHandler> _log;

        public LogEventHandler(ILogger<LogEventHandler> log)
        {
            _log = log;
        }

        public Task Handle(ElementoPumpCadastradoNotification notification, CancellationToken cancellationToken)
        {
            _log.LogWarning("Cadastrado com sucesso");
            return Task.CompletedTask;
        }
    }
}