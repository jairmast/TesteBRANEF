using MediatR;
using System.Runtime.Serialization;

namespace TesteBRANEF.API.Application.Commands
{
    public class AlterarClienteCommand : IRequest<bool>
    {
        [DataMember]
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public int TipoEmpresa { get; set; }

        public AlterarClienteCommand()
        { }

        public AlterarClienteCommand(int id, string nomeCliente, int TipoEmpresa)
        {
            Id = id;
            this.NomeCliente = nomeCliente;
            this.TipoEmpresa = TipoEmpresa;
        }
    }
}
