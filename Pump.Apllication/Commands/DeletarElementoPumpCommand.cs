using MediatR;

namespace Pump.Apllication.Commands
{
    public class DeletarElementoPumpCommand : IRequest<bool>
    {
        public DeletarElementoPumpCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}