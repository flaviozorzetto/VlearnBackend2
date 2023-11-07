using System.ComponentModel.DataAnnotations;

namespace VlearnBackend2.Models.Dto
{
    public class TelefoneRequestDto
    {
        [Required]
        public string? Ddd { get; set; }

        [Required]
        public string? Ddi { get; set; }

        [Required]
        public string? Nr_telefone { get; set; }
    }
}
