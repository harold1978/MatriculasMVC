using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatriculasMVC.Migrations
{
    /// <inheritdoc />
    public partial class segundaM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursosId",
                table: "Asistencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_CursosId",
                table: "Asistencias",
                column: "CursosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Cursos_CursosId",
                table: "Asistencias",
                column: "CursosId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_Cursos_CursosId",
                table: "Asistencias");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Asistencias_CursosId",
                table: "Asistencias");

            migrationBuilder.DropColumn(
                name: "CursosId",
                table: "Asistencias");
        }
    }
}
