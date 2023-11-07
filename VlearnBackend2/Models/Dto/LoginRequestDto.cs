using System.ComponentModel.DataAnnotations;

namespace VlearnBackend2.Models.Dto
{
    public class LoginRequestDto
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Senha { get; set; }
    }
}
