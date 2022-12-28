
using AutoMapper;
using MediatR;
using Pump.Apllication.Commands;
using Pump.Apllication.Notifications;
using Pump.Domain.Interfaces;

namespace Pump.Apllication.Handlers
{

    public class DeletarElementoPumpCommandHandler : IRequestHandler<DeletarElementoPumpCommand, bool>
    {
        private readonly IMapper _mapper;

        private readonly IRepository _repositoryElemento;

        private readonly IMediator _mediator;

        public DeletarElementoPumpCommandHandler(IMapper mapper, IRepository repositoryElemento, IMediator mediator)
        {
            _mapper = mapper;
            _repositoryElemento = repositoryElemento;
            _mediator = mediator;
        }
        
        public async Task<bool> Handle(DeletarElementoPumpCommand request, CancellationToken cancellationToken)
        {
            var elementoRemove = _repositoryElemento.GetElementoId(request.Id);              
            if (elementoRemove != null && _repositoryElemento.DeleteElemento(elementoRemove))
            {
                await _mediator.Publish(new ElementoPumpDeletadoNotification(elementoRemove));
                return true;
            }

            return false;
        }
    }
}