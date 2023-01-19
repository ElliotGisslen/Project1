using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyClassLibrary.Migrations
{
    public partial class UpdatedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Shape",
                table: "ShapeResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ShapeType",
                table: "ShapeResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Shape" },
                values: new object[] { new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5026), "Rektangel" });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "Date", "Input1", "Input3", "Shape", "ShapeType" },
                values: new object[] { 1.73, new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5105), 2.0, 2.0, "Triangel", 2 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "Date", "Input3", "Shape", "ShapeType" },
                values: new object[] { 4.0, new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5110), 1.0, "Romb", 1 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Shape", "ShapeType" },
                values: new object[] { new DateTime(2023, 1, 18, 13, 27, 18, 14, DateTimeKind.Local).AddTicks(5115), "Parallelogram", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shape",
                table: "ShapeResults");

            migrationBuilder.DropColumn(
                name: "ShapeType",
                table: "ShapeResults");

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "Date", "Input1", "Input3" },
                values: new object[] { 2.0, new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7745), 1.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "Date", "Input3" },
                values: new object[] { 2.0, new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7751), 0.0 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7757));
        }
    }
}
