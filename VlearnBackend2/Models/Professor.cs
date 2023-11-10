using System.ComponentModel.DataAnnotations.Schema;

namespace VlearnBackend2.Models
{
    [Table("TABLE_VLEARN_PROFESSOR")]
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
