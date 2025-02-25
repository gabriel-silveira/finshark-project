using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedStockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CompanyName", "CreatedAt", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[,]
                {
                    { 1, "Hapvida", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3312), "Saúde", 2m, 3L, 1m, "HAPV3" },
                    { 2, "B3", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3352), "Mercado financeiro", 2m, 3L, 1m, "B3SA3" },
                    { 3, "Cosan", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3356), "Etanol", 2m, 3L, 1m, "CSAN3" },
                    { 4, "Lojas Renner", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3359), "Vestuário", 2m, 3L, 1m, "LREN3" },
                    { 5, "Cogna", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3363), "Educação", 2m, 3L, 1m, "COGN3" },
                    { 6, "Azevedo & Travassos", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3367), "Construção", 2m, 3L, 1m, "AZEV4" },
                    { 7, "Magazine Luiza", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3370), "Varejo", 2m, 3L, 1m, "MGLU3" },
                    { 8, "Banco Bradesco", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3374), "Banco", 2m, 3L, 1m, "BBDC4" },
                    { 9, "Ambev", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3377), "Bebidas", 2m, 3L, 1m, "ABEV3" },
                    { 10, "Banco do Brasil", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3380), "Banco", 2m, 3L, 1m, "BBAS3" },
                    { 11, "Petrobras", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3383), "Combustíveis", 2m, 3L, 1m, "PETR4" },
                    { 12, "Azul", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3387), "Companhias aéreas", 2m, 3L, 1m, "AZUL4" },
                    { 13, "Itaú Unibanco", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3390), "Banco", 2m, 3L, 1m, "ITUB4" },
                    { 14, "Itaúsa", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3394), "Holding", 2m, 3L, 1m, "ITSA4" },
                    { 15, "CVC", new DateTime(2025, 2, 25, 11, 59, 11, 887, DateTimeKind.Local).AddTicks(3397), "Turismo", 2m, 3L, 1m, "CVCB3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
