using System;

namespace APSLeonardo.Models.Cliente
{
    public class ClienteEntity
    {
        
            public string Nome { get; set; }
            public string Email { get; set; }
            public DateTime Inserido { get; set; }
            public DateTime UltimaMod { get; set; }
            public TipoCliente TipoCliente { get; set; }
            public int Cpf { get; set; }
            public int Cnpj { get; set; }
            public DateTime DataNasimento { get; set; }
            public string Observacoes { get; set; }
            public string Endereco { get; set; }
        }
    
}