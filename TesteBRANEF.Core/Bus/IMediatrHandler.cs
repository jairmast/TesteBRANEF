using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TesteBRANEF.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento);
    }
}
