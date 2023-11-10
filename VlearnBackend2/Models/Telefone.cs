using System.ComponentModel.DataAnnotations.Schema;

namespace VlearnBackend2.Models
{
    [Table("TABLE_VLEARN_TELEFONE")]
    public class Telefone
    {
        public int Id { get; set; }
        public string? Ddd { get; set; }
        public string? Ddi { get; set; }
        public string? Nr_telefone { get; set; }
    }
}
