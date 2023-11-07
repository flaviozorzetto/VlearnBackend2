namespace VlearnBackend2.Models.Dto
{
    public class CursoRequestDto
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double Preco { get; set; }
        public string? Autor { get; set; }
        public string? Duracao { get; set; }
        public Professor? Professor { get; set; }
    }
}
