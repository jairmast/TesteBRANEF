using MediatR;
using System.Runtime.Serialization;

namespace TesteBRANEF.API.Application.Commands
{
    public class InserirClienteCommand : IRequest<bool>
    {
        [DataMember]
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public int TipoEmpresa { get; set; }
        

        public InserirClienteCommand()
        { }
        public InserirClienteCommand(int id, string nomeCliente, int tipoEmpresa)
        {
            Id = id;
            NomeCliente = nomeCliente;
            TipoEmpresa = tipoEmpresa;
            
        }
    }
}
