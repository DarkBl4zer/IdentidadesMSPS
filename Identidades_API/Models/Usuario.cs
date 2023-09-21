using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identidades_API.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(2)]
        [Column(TypeName = "varchar(2)")]
        public required string TipoIdentificacion { get; set; }

        [Required]
        [MaxLength(17)]
        [Column(TypeName = "varchar(17)")]
        public required string NroIdentificacion { get; set; }

        [Required]
        [MaxLength(60)]
        [Column(TypeName = "varchar(60)")]
        public required string PrimerNombre { get; set; }

        [Required]
        [MaxLength(60)]
        [Column(TypeName = "varchar(60)")]
        public required string SegundoNombre { get; set; }

        [Required]
        [MaxLength(60)]
        [Column(TypeName = "varchar(60)")]
        public required string PrimerApellido { get; set; }

        [Required]
        [MaxLength(60)]
        [Column(TypeName = "varchar(60)")]
        public required string SegundoApellido { get; set; }

    }
}
