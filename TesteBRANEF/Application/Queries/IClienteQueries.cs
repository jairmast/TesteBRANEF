using TesteBRANEF.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBRANEF.API.Application.Queries
{
    public interface IClienteQueries
    {
        
        Task<IEnumerable<Cliente>> ObterClientes();
        Task<Cliente> ConsultarCliente(int id);

    }
}
