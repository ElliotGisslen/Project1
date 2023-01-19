using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyClassLibrary.Migrations
{
    public partial class AddedRockPaperScissors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RockPaperScissorsResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinOrLoss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentWinRatio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RockPaperScissorsResults", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 18, 18, 30, 19, 228, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 18, 18, 30, 19, 228, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 1, 18, 18, 30, 19, 228, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 1, 18, 18, 30, 19, 228, DateTimeKind.Local).AddTicks(9378));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RockPaperScissorsResults");

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 18, 16, 44, 32, 990, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 18, 16, 44, 32, 990, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 1, 18, 16, 44, 32, 990, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 1, 18, 16, 44, 32, 990, DateTimeKind.Local).AddTicks(1666));
        }
    }
}
