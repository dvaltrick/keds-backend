using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Models
{
    public class Questao
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public string ValorCorreto { get; set; }

        public Guid ProvaId { get; set; }

        public Prova Prova { get; set; }

        public List<Alternativa> Alternativas { get; set; }
    }
}
