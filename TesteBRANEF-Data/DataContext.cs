using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TesteBRANEF.Core.Data;
using TesteBRANEF.Domain;

namespace TesteBRANEF_Data
{
    public class DataContext : DbContext, IUnitOfWork
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 

        }

        public DbSet<Cliente> Clientes { get; set; }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
    
}
