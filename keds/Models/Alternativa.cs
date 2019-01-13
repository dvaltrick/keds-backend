using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Models
{
    public class Alternativa
    {
        public Guid Id { get; set; }

        public string Texto { get; set; }

        public string Valor { get; set; }

        public Guid QuestaoId { get; set; }

        public Questao Questao { get; set; }

    }
}
