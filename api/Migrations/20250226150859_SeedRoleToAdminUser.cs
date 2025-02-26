using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleToAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "39ee54d4-068b-4643-9e80-0f26bb65a70a", "68060241-8072-41c9-bef4-ab60b3f4a857" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 8, 59, 200, DateTimeKind.Local).AddTicks(1911));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39ee54d4-068b-4643-9e80-0f26bb65a70a", "68060241-8072-41c9-bef4-ab60b3f4a857" });

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 26, 12, 4, 37, 55, DateTimeKind.Local).AddTicks(9114));
        }
    }
}
