using System.ComponentModel.DataAnnotations.Schema;

namespace VlearnBackend2.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? TipoPcd { get; set; }
        public Login? Login { get; set; }
        public Telefone? Telefone { get; set; }
    }
}
