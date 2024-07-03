using TesteBRANEF.Domain;
using OpenTracing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBRANEF.API.Application.Queries
{
    public class ClienteQueries : IClienteQueries
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteQueries(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        public async Task<IEnumerable<Cliente>> ObterClientes()
        {
            return await _clienteRepository.ObterClientes();
        }

        public async Task<Cliente> ConsultarCliente(int Id)
        {
            
            return await _clienteRepository.ConsultarCliente(Id);
        }
        
    }
}
