using AutoMapper;
using MediatR;
using Pump.Apllication.Notifications;
using Pump.Apllication.Querys;
using Pump.Domain.Entity;
using Pump.Domain.Interfaces;

namespace Pump.Apllication.Handlers
{
    public class ConsultarElementoPumpQueryHandler : IRequestHandler<ConsultarElementoPumpQuery, ElementoPumpEntity>
    {
        private readonly IRepository _repositoryElemento;

        private readonly IMediator _mediator;
        public ConsultarElementoPumpQueryHandler(IRepository repositoryElemento, IMediator mediator)
        {
            _repositoryElemento = repositoryElemento;
            _mediator = mediator;
        }

        public async Task<ElementoPumpEntity?> Handle(ConsultarElementoPumpQuery request, CancellationToken cancellationToken)
        {
            var elementoEncontrado = _repositoryElemento.GetElementoId(request.id);
            if (elementoEncontrado != null)
            {
                await _mediator.Publish(new ElementoPumpConsultadoNotification(elementoEncontrado));
                return elementoEncontrado;
            }
            
            return null;
        }
    }
}