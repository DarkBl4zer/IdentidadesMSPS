using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identidades_API.Models
{
    public class Entidad
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
        [MaxLength(1)]
        [Column(TypeName = "varchar(1)")]
        public required string DigitoVerificacion { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar(250)")]
        public required string RazonSocial { get; set; }
    }
}
