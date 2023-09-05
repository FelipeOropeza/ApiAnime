using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAnime.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoFunc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Metas = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Resp = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcs");

            migrationBuilder.DropTable(
                name: "Persos");

            migrationBuilder.DropTable(
                name: "Poders");
        }
    }
}
