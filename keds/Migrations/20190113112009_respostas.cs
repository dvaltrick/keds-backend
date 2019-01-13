using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace keds.Migrations
{
    public partial class respostas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Simulados",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProvaId = table.Column<Guid>(nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Questoes = table.Column<int>(nullable: false),
                    Acetadas = table.Column<int>(nullable: false),
                    Erradas = table.Column<int>(nullable: false),
                    Puladas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Simulados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Simulados_Provas_ProvaId",
                        column: x => x.ProvaId,
                        principalTable: "Provas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Simulados_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Respostas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SimuladoId = table.Column<Guid>(nullable: false),
                    QuestaoId = table.Column<Guid>(nullable: false),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respostas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Respostas_Questoes_QuestaoId",
                        column: x => x.QuestaoId,
                        principalTable: "Questoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Respostas_Simulados_SimuladoId",
                        column: x => x.SimuladoId,
                        principalTable: "Simulados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Respostas_QuestaoId",
                table: "Respostas",
                column: "QuestaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Respostas_SimuladoId",
                table: "Respostas",
                column: "SimuladoId");

            migrationBuilder.CreateIndex(
                name: "IX_Simulados_ProvaId",
                table: "Simulados",
                column: "ProvaId");

            migrationBuilder.CreateIndex(
                name: "IX_Simulados_UsuarioId",
                table: "Simulados",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Respostas");

            migrationBuilder.DropTable(
                name: "Simulados");
        }
    }
}
