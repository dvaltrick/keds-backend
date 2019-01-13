using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Models
{
    public class Resposta
    {
        public Guid Id { get; set; }
        public Guid SimuladoId {get; set;}
        public Simulado Simulado { get; set; }
        public Guid QuestaoId { get; set; }
        public Questao Questao { get; set; }
        public string Valor { get; set; }
    }
}
