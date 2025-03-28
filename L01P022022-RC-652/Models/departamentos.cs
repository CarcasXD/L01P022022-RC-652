using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022_RC_652.Models
{
    public class departamentos
    {
        [Key]
        [Required]
        [DisplayName("Id de departamento")]
        public int id { get; set; }
        [Required]
        [DisplayName("Nombre de departamento")]
        public string? departamento { get; set; }
    }
}
