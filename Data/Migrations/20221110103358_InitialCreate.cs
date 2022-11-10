using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LongURl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "date", maxLength: 20, nullable: false),
                    VisitsNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Date", "LongURl", "ShortURL", "VisitsNumber" },
                values: new object[] { new Guid("51baed5b-7c28-4f1c-a698-f1f11f1cf768"), new DateTime(2022, 11, 10, 13, 33, 58, 568, DateTimeKind.Local).AddTicks(9261), "https://learn.javascript.ru/", "learn.javascript.ru", 0 });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Date", "LongURl", "ShortURL", "VisitsNumber" },
                values: new object[] { new Guid("d6a99653-0dc8-41c6-b492-076ec98ff360"), new DateTime(2022, 11, 10, 13, 33, 58, 568, DateTimeKind.Local).AddTicks(9271), "https://metanit.com/sharp/", "metanit.com/sharp", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");
        }
    }
}
