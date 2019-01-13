using Microsoft.EntityFrameworkCore.Migrations;

namespace keds.Migrations
{
    public partial class acertada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Acetadas",
                table: "Simulados",
                newName: "Acertadas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Acertadas",
                table: "Simulados",
                newName: "Acetadas");
        }
    }
}
