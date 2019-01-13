using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Models
{
    public class Instituicao
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }
        
        public List<Prova> Provas { get; set; }
    }
}
