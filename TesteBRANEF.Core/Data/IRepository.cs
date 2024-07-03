using System;

namespace TesteBRANEF.Core.Data
{

    public interface IRepository<T>
    {
        IUnitOfWork UnitOfWork { get; }
    }
}