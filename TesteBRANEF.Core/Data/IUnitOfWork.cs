using System.Threading.Tasks;

namespace TesteBRANEF.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}