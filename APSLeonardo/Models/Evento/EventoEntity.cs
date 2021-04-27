using System;
using System.ComponentModel.DataAnnotations;
using APSLeonardo.Models.Cliente;

namespace APSLeonardo.Models.Evento
{
    public class EventoEntity
    {
        public TipoEvento TipoEvento { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public TimestampAttribute Horainicio { get; set; }
        public TimestampAttribute Horafim { get; set; }
        public ClienteEntity Cliente { get; set; }
        public SituacaoEvento Situacao { get; set; }
        public string Endereco { get; set; }
        public string Observacoes { get; set; }
        public DateTime Inserido { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}