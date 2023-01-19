using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyClassLibrary.Migrations
{
    public partial class AddedCalculations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculationResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Input1 = table.Column<double>(type: "float", nullable: false),
                    Input2 = table.Column<double>(type: "float", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationResults", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculationResults");

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5115));
        }
    }
}
