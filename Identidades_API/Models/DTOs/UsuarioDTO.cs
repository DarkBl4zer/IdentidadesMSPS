namespace Identidades_API.Models.DTOs
{
    public class UsuarioDTO
    {
        public string? TipoIdentificacion { get; set; }

        public string? NroIdentificacion { get; set; }

        public string? PrimerNombre { get; set; }

        public string? SegundoNombre { get; set; }

        public string? PrimerApellido { get; set; }

        public string? SegundoApellido { get; set; }
    }
}
