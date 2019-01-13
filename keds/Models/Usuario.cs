using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        
        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        [NotMapped]
        public string Token { get; internal set; }

    }
}
