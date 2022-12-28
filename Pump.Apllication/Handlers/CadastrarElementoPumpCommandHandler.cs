using AutoMapper;
using MediatR;
using Pump.Apllication.Commands;
using Pump.Apllication.Notifications;
using Pump.Domain.Entity;
using Pump.Domain.Interfaces;

namespace Pump.Apllication.Handlers
{
    public class CadastrarElementoPumpCommandHandler : IRequestHandler<CadastrarElementoPumpCommand, bool>
    {
        private readonly IMapper _mapper;

        private readonly IRepository _repositoryElemento;

        private readonly IMediator _mediator;

        public CadastrarElementoPumpCommandHandler(IMapper mapper, IRepository repositoryElemento, IMediator mediator)
        {
            _mapper = mapper;
            _repositoryElemento = repositoryElemento;
            _mediator = mediator;
        }

        public async Task<bool> Handle(CadastrarElementoPumpCommand request, CancellationToken cancellationToken)
        {
            var elementoAdd = _mapper.Map<ElementoPumpEntity>(request);
            if (_repositoryElemento.InsertElemento(elementoAdd))
            {
                await _mediator.Publish(new ElementoPumpCadastradoNotification(elementoAdd));
                return true;
            }

            return false;
        }
    }
}