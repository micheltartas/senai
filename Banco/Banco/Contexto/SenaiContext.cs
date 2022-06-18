using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Banco.Contexto
{
    public class SenaiContext : DbContext
    {
        public DbSet<Escola> Escola { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Professor> Professor { get; set; }

        public DbSet<Classe> Classe {get; set;}
        
        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Senai;User Id=postgres;Password=admin");
        }
    }
}
