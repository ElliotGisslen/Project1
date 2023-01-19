using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyClassLibrary.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShapeResults",
                columns: new[] { "Id", "Area", "Date", "Input1", "Input2", "Input3", "Perimeter" },
                values: new object[,]
                {
                    { 1, 2.0, new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7653), 1.0, 2.0, 0.0, 6.0 },
                    { 2, 2.0, new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7745), 1.0, 2.0, 0.0, 6.0 },
                    { 3, 2.0, new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7751), 1.0, 2.0, 0.0, 6.0 },
                    { 4, 2.0, new DateTime(2023, 1, 18, 10, 49, 21, 22, DateTimeKind.Local).AddTicks(7757), 1.0, 2.0, 0.0, 6.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
