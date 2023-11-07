using System.Runtime.InteropServices;

namespace VlearnBackend2.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double Preco { get; set; }
        public string? Autor { get; set; }
        public string? Duracao { get; set; }
        public Professor? Professor { get; set; }
    }
}
