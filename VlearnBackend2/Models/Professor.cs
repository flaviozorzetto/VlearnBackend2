using System.Runtime.InteropServices;

namespace VlearnBackend2.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Formacao { get; set; }
        public string? Experiencia { get; set; }
        public string? Idiomas { get; set; }
        public string? Status { get; set; }
        public Login? Login { get; set; }
        public Telefone? Telefone { get; set; }
    }
}
