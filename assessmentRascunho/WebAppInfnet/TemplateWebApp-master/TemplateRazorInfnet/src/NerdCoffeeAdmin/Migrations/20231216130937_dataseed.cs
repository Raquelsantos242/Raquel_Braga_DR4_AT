 using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuMiniMuseu.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pintura",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pintura",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pintura",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Pintura",
                columns: new[] { "Id", "AnoCriacao", "Artista", "Created", "ImageFile", "ImageFileName", "Movimento", "Nome" },
                values: new object[] { 14, "1899", "Alfons Maria Mucha", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alfons.jpg", null, "Art Noveau", "Woman with Daisies" });

            migrationBuilder.InsertData(
                table: "Pintura",
                columns: new[] { "Id", "AnoCriacao", "Artista", "Created", "ImageFile", "ImageFileName", "Movimento", "Nome" },
                values: new object[] { 15, "1917", "Hans Larwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "death.jpg", null, "Academicismo", "Death and the Soldier" });

            migrationBuilder.InsertData(
                table: "Pintura",
                columns: new[] { "Id", "AnoCriacao", "Artista", "Created", "ImageFile", "ImageFileName", "Movimento", "Nome" },
                values: new object[] { 16, "1879", "Hanuš Knöchel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seashore.jpg", null, "Academicismo", "On the Seashore" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pintura",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pintura",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pintura",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.InsertData(
                table: "Pintura",
                columns: new[] { "Id", "AnoCriacao", "Artista", "Created", "ImageFile", "ImageFileName", "Movimento", "Nome" },
                values: new object[] { 2, "1899", "Alfons Maria Mucha", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alfons.jpg", null, "Art Noveau", "Woman with Daisies" });

            migrationBuilder.InsertData(
                table: "Pintura",
                columns: new[] { "Id", "AnoCriacao", "Artista", "Created", "ImageFile", "ImageFileName", "Movimento", "Nome" },
                values: new object[] { 3, "1917", "Hans Larwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "death.jpg", null, "Academicismo", "Death and the Soldier" });

            migrationBuilder.InsertData(
                table: "Pintura",
                columns: new[] { "Id", "AnoCriacao", "Artista", "Created", "ImageFile", "ImageFileName", "Movimento", "Nome" },
                values: new object[] { 4, "1879", "Hanuš Knöchel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seashore.jpg", null, "Academicismo", "On the Seashore" });
        }
    }
}
