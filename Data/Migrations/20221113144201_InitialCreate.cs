using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LongURl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShortURL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    VisitsNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Date", "LongURl", "ShortURL", "VisitsNumber" },
                values: new object[] { new Guid("595110a0-c68d-4839-8829-5ed18a50ef8c"), new DateTime(2022, 11, 13, 17, 42, 0, 999, DateTimeKind.Local).AddTicks(4311), "https://metanit.com/sharp/", "metanit.com/sharp", 0 });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Date", "LongURl", "ShortURL", "VisitsNumber" },
                values: new object[] { new Guid("611380c0-85ef-4855-9d14-547c02370888"), new DateTime(2022, 11, 13, 17, 42, 0, 999, DateTimeKind.Local).AddTicks(4299), "https://learn.javascript.ru/", "learn.javascript.ru", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");
        }
    }
}
