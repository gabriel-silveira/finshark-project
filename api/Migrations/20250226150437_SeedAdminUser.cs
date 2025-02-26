using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "68060241-8072-41c9-bef4-ab60b3f4a857", 0, "57e949a6-ef8e-405f-b748-c28672aa43d6", "admin@finshark.com", false, true, null, "ADMIN@FINSHARK.COM", "ADMIN", "AQAAAAIAAYagAAAAED3Hup7iBlNlErNbFzFPNx/C19h+RFlOL5IPka7CZ8IhZ4FCY+NWKDIZlkTl+jVQ+w==", null, false, "MMRSHQWTAIMEP3J4NADMHRMAXKAPCF6K", false, "admin" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68060241-8072-41c9-bef4-ab60b3f4a857");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 2, 25, 18, 56, 30, 427, DateTimeKind.Local).AddTicks(6721));
        }
    }
}
