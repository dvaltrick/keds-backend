using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Models
{
    public class Prova
    {
        public Guid Id { get; set; }

        public int Ano { get; set; }

        public int Periodo { get; set; }

        public Guid InstituicaoId { get; set; }

        public Instituicao Instituicao { get; set; }

        List<Questao> Questoes { get; set; }

        public int Tempo { get; set; }
    }
}
