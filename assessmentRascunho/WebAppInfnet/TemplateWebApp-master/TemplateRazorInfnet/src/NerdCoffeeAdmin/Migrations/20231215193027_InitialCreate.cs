using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuMiniMuseu.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pintura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Movimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoCriacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pintura", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pintura");
        }
    }
}
