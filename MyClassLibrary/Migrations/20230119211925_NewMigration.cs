using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyClassLibrary.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 19, 22, 19, 24, 521, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "Date", "Input1", "Input2", "Input3", "Perimeter" },
                values: new object[] { 12.5, new DateTime(2023, 1, 19, 22, 19, 24, 522, DateTimeKind.Local).AddTicks(73), 5.0, 5.0, 7.0, 17.0 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "Date", "Input1", "Input2", "Input3", "Perimeter" },
                values: new object[] { 120.0, new DateTime(2023, 1, 19, 22, 19, 24, 522, DateTimeKind.Local).AddTicks(79), 13.0, 24.0, 10.0, 52.0 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Area", "Date", "Input1", "Input2", "Input3", "Perimeter" },
                values: new object[] { 72.0, new DateTime(2023, 1, 19, 22, 19, 24, 522, DateTimeKind.Local).AddTicks(84), 12.0, 8.0, 6.0, 40.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Area", "Date", "Input1", "Input2", "Input3", "Perimeter" },
                values: new object[] { 1.73, new DateTime(2023, 1, 18, 18, 30, 19, 228, DateTimeKind.Local).AddTicks(9373), 2.0, 2.0, 2.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "Date", "Input1", "Input2", "Input3", "Perimeter" },
                values: new object[] { 4.0, new DateTime(2023, 1, 18, 18, 30, 19, 228, DateTimeKind.Local).AddTicks(9375), 1.0, 2.0, 1.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "ShapeResults",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Area", "Date", "Input1", "Input2", "Input3", "Perimeter" },
                values: new object[] { 2.0, new DateTime(2023, 1, 18, 18, 30, 19, 228, DateTimeKind.Local).AddTicks(9378), 1.0, 2.0, 0.0, 6.0 });
        }
    }
}
