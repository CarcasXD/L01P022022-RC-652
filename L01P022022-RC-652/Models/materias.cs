using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022_RC_652.Models
{
    public class materias
    {
        [Key]
        [Required]
        [DisplayName("Id de materia")]
        public int id { get; set; }
        [Required]
        [DisplayName("Nombre de la materia")]
        public string? materia { get; set; }
        [Required]
        [DisplayName("Unidades Valorativas")]
        public int? unidades_valorativas { get; set; }
        [Required]
        [DisplayName("Estado de la materia")]
        public string? estado { get; set; }
    }
}
