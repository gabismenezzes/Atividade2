using System;
using APSLeonardo.Models.Evento;

namespace APSLeonardo.Models.Convidado
{
    public class ConvidadoEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public DateTime DatadeNascimento { get; set; }
        public EventoEntity Evento { get; set; }
        public SituacaoConvidado SituacaoConvidado { get; set; }
        public string Observaçoes { get; set; }
        public DateTime Inserido { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}