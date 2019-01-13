using Microsoft.EntityFrameworkCore.Migrations;

namespace keds.Migrations
{
    public partial class simulado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tempo",
                table: "Provas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tempo",
                table: "Provas");
        }
    }
}
