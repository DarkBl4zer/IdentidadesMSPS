using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Identidades_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimantarTablaUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NroIdentificacion", "PrimerApellido", "PrimerNombre", "SegundoApellido", "SegundoNombre", "TipoIdentificacion" },
                values: new object[,]
                {
                    { 1, "72334103", "Manjarrés", "Fernando", "Paternina", "Dario", "CC" },
                    { 2, "1026266986", "Rodríguez", "Nohora", "Mora", "Julieth", "CC" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
