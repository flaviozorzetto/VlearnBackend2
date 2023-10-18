namespace VlearnBackend2.Models.Dto
{
    public class AlunoRequestDto
    {
        public string? Nome { get; set; }
        public string? TipoPcd { get; set; }
        public Login? Login { get; set; }
        public Telefone? Telefone { get; set; }
    }
}
