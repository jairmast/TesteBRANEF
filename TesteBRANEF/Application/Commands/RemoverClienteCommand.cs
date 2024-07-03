using MediatR;
using System.Runtime.Serialization;

namespace TesteBRANEF.API.Application.Commands
{
    public class RemoverClienteCommand : IRequest<bool>
    {

        [DataMember]
        public int Id { get; set; }


        public RemoverClienteCommand()
        { }
        public RemoverClienteCommand(int id)
        {
            Id = id;

        }

    }
}
