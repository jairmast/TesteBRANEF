using TesteBRANEF.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TesteBRANEF.API.Application.Commands
{
    public class InserirClienteCommandHandler : IRequestHandler<InserirClienteCommand, bool>
    {
        private readonly IClienteRepository _clienteRepository;

        public InserirClienteCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<bool> Handle(InserirClienteCommand command, CancellationToken cancellationToken)
        {
            var clienteInserir = new Cliente(command.Id, command.NomeCliente, command.TipoEmpresa);

            _clienteRepository.Adicionar(clienteInserir);
            return _clienteRepository.UnitOfWork.Commit(); 
        }
    }
}