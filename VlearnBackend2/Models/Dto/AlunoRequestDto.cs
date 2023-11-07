using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VlearnBackend2.Models.Dto
{
    public class AlunoRequestDto
    {
        [Required]
        public string? Nome { get; set; }

        [JsonPropertyName("tipo_pcd")]
        [Required]
        public string? TipoPcd { get; set; }
        public Login? Login { get; set; }
        public Telefone? Telefone { get; set; }
    }
}
