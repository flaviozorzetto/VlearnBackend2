using Microsoft.EntityFrameworkCore;
using VlearnBackend2.Models;

namespace VlearnBackend2.Contexts
{
    public class PlataformaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        public PlataformaContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
