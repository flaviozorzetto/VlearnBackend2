using Microsoft.EntityFrameworkCore;
using VlearnBackend2.Models;

namespace VlearnBackend2.Contexts
{
    public class PlataformaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Professor> Professor{ get; set; }
        public DbSet<Telefone> Telefone { get; set; }

        public PlataformaContext(DbContextOptions op) : base(op) { }
    }
}
