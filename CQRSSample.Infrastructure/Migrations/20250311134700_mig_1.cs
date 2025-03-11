using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRSSample.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Products",
                newName: "ComunicationType");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Consumption");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductCode",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Consumption",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "ComunicationType",
                table: "Products",
                newName: "StockQuantity");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "StockQuantity", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün 1 açıklaması", "Ürün 1", 100.50m, 10, null },
                    { 2, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ürün 2 açıklaması", "Ürün 2", 200.75m, 5, null }
                });
        }
    }
}
