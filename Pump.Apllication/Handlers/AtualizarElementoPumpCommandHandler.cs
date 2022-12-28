using AutoMapper;
using MediatR;
using Pump.Apllication.Commands;
using Pump.Apllication.Notifications;
using Pump.Domain.Interfaces;

namespace Pump.Apllication.Handlers
{
    public class AtualizarElementoPumpCommandHandler : IRequestHandler<AtualizarElementoPumpCommand,bool>
    {
        private readonly IMapper _mapper;

        private readonly IRepository _repositoryElemento;

        private readonly IMediator _mediator;

        public AtualizarElementoPumpCommandHandler(IMapper mapper, IRepository repositoryElemento, IMediator mediator)
        {
            _mapper = mapper;
            _repositoryElemento = repositoryElemento;
            _mediator = mediator;
        }

        public async Task<bool> Handle(AtualizarElementoPumpCommand request, CancellationToken cancellationToken)
        {
            var buscaModel = _repositoryElemento.GetElementoId(request.Id);
            if (buscaModel != null)
            {
                buscaModel = _mapper.Map(request, buscaModel);
                if (_repositoryElemento.UpdateElemento(buscaModel))
                {
                    await _mediator.Publish(new ElementoPumpAtualizadoNotification(buscaModel));
                    return true;
                }
            }
            
            return false;
        }
    }
}