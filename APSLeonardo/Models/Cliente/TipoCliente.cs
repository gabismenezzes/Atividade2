using System;

namespace APSLeonardo.Models.Cliente
{
    public class TipoCliente
    {
        public int id { get; set; }
        public Boolean PessoaFisica{ get; set; }    
        public Boolean PessoaJuridica{ get; set; }
    }
}