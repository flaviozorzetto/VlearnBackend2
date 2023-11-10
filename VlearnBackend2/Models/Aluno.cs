using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VlearnBackend2.Models
{
    [Table("TABLE_VLEARN_ALUNO")]
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        [JsonPropertyName("tipo_pcd")]
        public string? TipoPcd { get; set; }
        public Login? Login { get; set; }
        public Telefone? Telefone { get; set; }
    }
}
