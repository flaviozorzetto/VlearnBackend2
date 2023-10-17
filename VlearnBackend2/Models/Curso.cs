using System.Runtime.InteropServices;

namespace VlearnBackend2.Models
{
    public class Curso
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public double preco { get; set; }
        public string? autor { get; set; }
        public string? duracao { get; set; }
        public Professor? professor { get; set; }
    }
}
