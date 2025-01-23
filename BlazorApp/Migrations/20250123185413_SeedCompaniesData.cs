using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompaniesData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("049333bb-0b1f-4bf5-af71-fc51130a6b9b"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("61796885-73a0-4f9c-b99e-6ded8fb09e79"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("769ef9c9-1364-48d9-aeba-87ae372a8034"));

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "cnpj", "created_at", "deleted_at", "reason", "updated_at" },
                values: new object[,]
                {
                    { new Guid("b8a8a9a7-0c5e-4f34-8b3a-5e23fbc3e67b"), "22.333.444/0001-55", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Comércio do Bairro EIRELI", null },
                    { new Guid("d8b6a3b4-0b58-4bfb-8a3f-37f5b2e33dc1"), "12.345.678/0001-90", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Empresa Exemplo LTDA", null },
                    { new Guid("f3b54699-2cd2-411c-ae6e-08bfb8fbc3b5"), "98.765.432/0001-09", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tech Solutions S.A.", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("b8a8a9a7-0c5e-4f34-8b3a-5e23fbc3e67b"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("d8b6a3b4-0b58-4bfb-8a3f-37f5b2e33dc1"));

            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "id",
                keyValue: new Guid("f3b54699-2cd2-411c-ae6e-08bfb8fbc3b5"));

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "cnpj", "created_at", "deleted_at", "reason", "updated_at" },
                values: new object[,]
                {
                    { new Guid("049333bb-0b1f-4bf5-af71-fc51130a6b9b"), "98.765.432/0001-09", new DateTime(2025, 1, 23, 18, 51, 39, 630, DateTimeKind.Utc).AddTicks(1033), null, "Tech Solutions S.A.", null },
                    { new Guid("61796885-73a0-4f9c-b99e-6ded8fb09e79"), "22.333.444/0001-55", new DateTime(2025, 1, 23, 18, 51, 39, 630, DateTimeKind.Utc).AddTicks(1035), null, "Comércio do Bairro EIRELI", null },
                    { new Guid("769ef9c9-1364-48d9-aeba-87ae372a8034"), "12.345.678/0001-90", new DateTime(2025, 1, 23, 18, 51, 39, 630, DateTimeKind.Utc).AddTicks(810), null, "Empresa Exemplo LTDA", null }
                });
        }
    }
}
