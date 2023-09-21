using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identidades_API.Migrations
{
    /// <inheritdoc />
    public partial class AddDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoIdentificacion = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    NroIdentificacion = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: false),
                    PrimerNombre = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    SegundoNombre = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    PrimerApellido = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false),
                    SegundoApellido = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
