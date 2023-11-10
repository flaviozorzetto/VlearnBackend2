using System.ComponentModel.DataAnnotations.Schema;

namespace VlearnBackend2.Models
{
    [Table("TABLE_VLEARN_LOGIN")]
    public class Login
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}
