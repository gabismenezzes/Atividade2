using System;

namespace APSLeonardo.Models.Evento
{
    public class SituacaoEvento
    {
        public int Id { get; set; }
        public Boolean Agendado{ get; set; }    
        public Boolean Cancelado{ get; set; }     
        public Boolean Executado{ get; set; }      
        public Boolean DemaisOutros{ get; set; }
    }
}