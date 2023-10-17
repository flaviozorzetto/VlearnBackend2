using System.Runtime.InteropServices;

namespace VlearnBackend2.Models
{
    public class Professor
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? formacao { get; set; }
        public string? experiencia { get; set; }
        public string? idiomas { get; set; }
        public string? status { get; set; }
        public Login? login { get; set; }
        public Telefone? telefone { get; set; }
    }
}
