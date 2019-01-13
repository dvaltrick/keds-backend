using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Models
{
    public class Simulado
    {
        public Guid Id { get; set; }
        public Guid ProvaId { get; set; }
        public Prova Prova { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<Resposta> Respostas { get; set; }

        public DateTime Data { get; set; }

        public int Questoes { get; set; }
        public int Acertadas { get; set; }
        public int Erradas { get; set; }
        public int Puladas { get; set; }
        public int Ultima { get; set; }

    }
}
