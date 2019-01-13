using Microsoft.EntityFrameworkCore.Migrations;

namespace keds.Migrations
{
    public partial class ultima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ultima",
                table: "Simulados",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ultima",
                table: "Simulados");
        }
    }
}
