using Identidades_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Identidades_API.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario()
                {
                    Id = 1,
                    TipoIdentificacion = "CC",
                    NroIdentificacion = "72334103",
                    PrimerNombre = "Fernando",
                    SegundoNombre = "Dario",
                    PrimerApellido = "Manjarrés",
                    SegundoApellido = "Paternina"
                },
                new Usuario()
                {
                    Id = 2,
                    TipoIdentificacion = "CC",
                    NroIdentificacion = "1026266986",
                    PrimerNombre = "Nohora",
                    SegundoNombre = "Julieth",
                    PrimerApellido = "Rodríguez",
                    SegundoApellido = "Mora"
                }
            );
        }
    }
}
