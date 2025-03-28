using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022_RC_652.Models
{
    public class alumnos
    {
        [Key]
        [Required]
        [DisplayName("Id de alumnos")]
        public int id { get; set; }
        [Required]
        [DisplayName("Codigo de alumno")]
        public string? codigo { get; set; }
        [Required]
        [DisplayName("Nombre de alumno")]
        public string? nombre { get; set; }
        [Required]
        [DisplayName("Apellido del alumno")]
        public string? apellidos { get; set; }
        [Required]
        [DisplayName("Dui del alumno")]
        public int? dui {  get; set; }
        [Required]
        [DisplayName("Estado del alumno")]
        public int? estado { get; set; }
    }
}
