namespace VlearnBackend2.Models.Dto
{
    public class CursoRequestDto
    {
        public string? nome { get; set; }
        public string? descricao { get; set; }
        public double preco { get; set; }
        public string? autor { get; set; }
        public string? duracao { get; set; }
        public Professor? professor { get; set; }
    }
}
