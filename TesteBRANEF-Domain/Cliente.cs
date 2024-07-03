using System;
using System.Collections.Generic;

namespace TesteBRANEF.Domain
{
    public partial class Cliente   
    {
        public int Id { get; private set; }
        public string NomeCliente { get; private set; }
        public int TipoEmpresa { get; private set; }

        public Cliente()
        {

        }

        public Cliente(int id)
        {
            this.Id = id;
        }

        public Cliente(int id, string nomeCliente, int tipoEmpresa)
        {
            this.Id = id;
            this.NomeCliente = nomeCliente;
            this.TipoEmpresa = tipoEmpresa;

        }



        public void AtualizarDadosClientes(int id, string nomeCliente, int tipoEmpresa)
        {
            this.Id = id;
            this.NomeCliente = nomeCliente;
            this.TipoEmpresa = tipoEmpresa;
            
        }
    }
}
