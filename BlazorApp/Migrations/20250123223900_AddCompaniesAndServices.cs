using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCompaniesAndServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    reason = table.Column<string>(type: "text", nullable: true),
                    cnpj = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    operation_value = table.Column<string>(type: "text", nullable: false),
                    estimatedtime = table.Column<string>(name: "estimated time", type: "text", nullable: true),
                    guarantee = table.Column<string>(type: "text", nullable: true),
                    type = table.Column<string>(type: "text", nullable: true),
                    company_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.id);
                    table.ForeignKey(
                        name: "FK_services_companies_company_id",
                        column: x => x.company_id,
                        principalTable: "companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "id", "cnpj", "created_at", "deleted_at", "reason", "updated_at" },
                values: new object[,]
                {
                    { new Guid("b8a8a9a7-0c5e-4f34-8b3a-5e23fbc3e67b"), "22.333.444/0001-55", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Comércio do Bairro EIRELI", null },
                    { new Guid("d8b6a3b4-0b58-4bfb-8a3f-37f5b2e33dc1"), "12.345.678/0001-90", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Empresa Exemplo LTDA", null },
                    { new Guid("f3b54699-2cd2-411c-ae6e-08bfb8fbc3b5"), "98.765.432/0001-09", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Tech Solutions S.A.", null }
                });

            migrationBuilder.InsertData(
                table: "services",
                columns: new[] { "id", "company_id", "created_at", "deleted_at", "estimated time", "guarantee", "name", "operation_value", "type", "updated_at" },
                values: new object[,]
                {
                    { new Guid("a1e8c4b4-0b67-4fbf-8a3f-37f5b2e33dc1"), new Guid("d8b6a3b4-0b58-4bfb-8a3f-37f5b2e33dc1"), new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), null, "2 horas", "3 meses", "Consultoria Técnica", "R$ 300,00", "Consultoria", null },
                    { new Guid("b2e9c5b5-1c78-5fcf-9b4f-48f6c3e44dd2"), new Guid("f3b54699-2cd2-411c-ae6e-08bfb8fbc3b5"), new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, "1 mês", "6 meses", "Desenvolvimento de Software", "R$ 5000,00", "Desenvolvimento", null },
                    { new Guid("c3f0d6c6-2d89-4fcf-0c5f-59f7d4e55ff3"), new Guid("b8a8a9a7-0c5e-4f34-8b3a-5e23fbc3e67b"), new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Utc), null, "3 dias", "1 ano", "Manutenção Predial", "R$ 1500,00", "Manutenção", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_services_company_id",
                table: "services",
                column: "company_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
