using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteBRANEF.Core.Data;

namespace TesteBRANEF.Domain
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        void Alterar(Cliente cliente);

        void Adicionar(Cliente cliente);

        void Remover(Cliente cliente);

        Task<IEnumerable<Cliente>> ObterClientes();
        Task<Cliente> ConsultarCliente(int id);

        
    }
}