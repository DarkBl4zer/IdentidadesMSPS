using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identidades_API.Models
{
    public class UsuarioInstitucional
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(2)]
        [Column(TypeName = "varchar(2)")]
        public required string TipoIDEntidad { get; set; }

        [Required]
        [MaxLength(12)]
        [Column(TypeName = "varchar(12)")]
        public required string NumeroIDEntidad { get; set; }

        [Required]
        [MaxLength(2)]
        [Column(TypeName = "varchar(2)")]
        public required string TipoIdentificacion { get; set; }

        [Required]
        [MaxLength(17)]
        [Column(TypeName = "varchar(17)")]
        public required string NroIdentificacion { get; set; }
    }
}
