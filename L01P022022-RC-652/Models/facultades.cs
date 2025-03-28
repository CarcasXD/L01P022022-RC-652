using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P022022_RC_652.Models
{
    public class facultades
    {
        [Key]
        [Required]
        [DisplayName("Id de facultad")]
        public int id { get; set; }
        [Required]
        [DisplayName("Nombre de facultad")]
        public string? facultad {  get; set; }
    }
}
