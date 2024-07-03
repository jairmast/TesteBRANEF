using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteBRANEF.Core.Data;
using TesteBRANEF.Domain;

namespace TesteBRANEF_Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            _context.Update(cliente);
        }

        public async Task<Cliente> ConsultarCliente(int id)
        {
            var cliente =  await _context.Clientes.Where(x => x.Id == id).FirstOrDefaultAsync();
            return cliente == null ? new Cliente() : cliente;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<IEnumerable<Cliente>> ObterClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public void Remover(Cliente cliente)
        {
            _context.Remove(cliente);
        }
    }
}
