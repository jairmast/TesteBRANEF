using TesteBRANEF.Domain;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace TesteBRANEF.API.Application.Commands
{
    public class RemoverClienteCommandHandler : IRequestHandler<RemoverClienteCommand,bool>
    {
        
            private readonly IClienteRepository _clienteRepository;

            public RemoverClienteCommandHandler(IClienteRepository clienteRepository)
            {
                _clienteRepository = clienteRepository;
            }

            public Task<bool> Handle(RemoverClienteCommand command, CancellationToken cancellationToken)
            {
                var clienteInserir = new Cliente(command.Id);

                _clienteRepository.Remover(clienteInserir);
                return _clienteRepository.UnitOfWork.Commit();
            }
        
    }
}
