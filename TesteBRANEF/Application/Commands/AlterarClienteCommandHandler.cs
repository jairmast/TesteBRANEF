using TesteBRANEF.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TesteBRANEF.API.Application.Commands
{
    public class AlterarClienteCommandHandler : IRequestHandler<AlterarClienteCommand, bool>
    {
        private readonly IClienteRepository _clienteRepository;

        public AlterarClienteCommandHandler(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task<bool> Handle(AlterarClienteCommand command, CancellationToken cancellationToken)
        {
            var clienteAlterar = new Cliente(command.Id);

            clienteAlterar.AtualizarDadosClientes(command.Id,command.NomeCliente,command.TipoEmpresa);

            _clienteRepository.Alterar(clienteAlterar);

            return _clienteRepository.UnitOfWork.Commit();
        }
    }
}