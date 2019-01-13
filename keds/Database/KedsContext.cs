using keds.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.Database
{
    public class KedsContext: DbContext
    {
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Questao> Questoes { get; set; }
        public DbSet<Alternativa> Alternativas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Simulado> Simulados { get; set; }
        public DbSet<Resposta> Respostas { get; set; }

        public KedsContext(DbContextOptions<KedsContext> options)
            : base(options)
        {
        }

        public KedsContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = DBConfigService.Carregar();
            //optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=softstore;User Id=postgres;Password=postgre;");
            optionsBuilder.UseNpgsql($"Server={config.Server};Port={config.Port};Database={config.Database};User Id={config.User};Password={config.Password};");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instituicao>()
                .HasMany(c => c.Provas)
                .WithOne(e => e.Instituicao);
        }
    }
}
