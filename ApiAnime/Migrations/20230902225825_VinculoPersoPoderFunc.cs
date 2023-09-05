using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAnime.Migrations
{
    public partial class VinculoPersoPoderFunc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FuncId",
                table: "Persos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PoderId",
                table: "Persos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persos_FuncId",
                table: "Persos",
                column: "FuncId");

            migrationBuilder.CreateIndex(
                name: "IX_Persos_PoderId",
                table: "Persos",
                column: "PoderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persos_Funcs_FuncId",
                table: "Persos",
                column: "FuncId",
                principalTable: "Funcs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persos_Poders_PoderId",
                table: "Persos",
                column: "PoderId",
                principalTable: "Poders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persos_Funcs_FuncId",
                table: "Persos");

            migrationBuilder.DropForeignKey(
                name: "FK_Persos_Poders_PoderId",
                table: "Persos");

            migrationBuilder.DropIndex(
                name: "IX_Persos_FuncId",
                table: "Persos");

            migrationBuilder.DropIndex(
                name: "IX_Persos_PoderId",
                table: "Persos");

            migrationBuilder.DropColumn(
                name: "FunId",
                table: "Persos");

            migrationBuilder.DropColumn(
                name: "FuncId",
                table: "Persos");

            migrationBuilder.DropColumn(
                name: "PoderId",
                table: "Persos");
        }
    }
}
