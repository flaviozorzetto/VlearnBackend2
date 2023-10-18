namespace VlearnBackend2.Models.Dto
{
    public class ProfessorRequestDto
    {
        public string? nome { get; set; }
        public string? formacao { get; set; }
        public string? experiencia { get; set; }
        public string? idiomas { get; set; }
        public string? status { get; set; }
        public Login? login { get; set; }
        public Telefone? telefone { get; set; }
    }
}
