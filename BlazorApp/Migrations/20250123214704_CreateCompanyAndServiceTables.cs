using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BlazorApp.Migrations
{
    public partial class CreateCompanyAndServiceTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    reason = table.Column<string>(nullable: true),
                    cnpj = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    operation_value = table.Column<string>(nullable: true),
                    estimated_time = table.Column<string>(nullable: true),
                    guarantee = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    company_id = table.Column<Guid>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: true),
                    deleted_at = table.Column<DateTime>(nullable: true)
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
                columns: new[] { "id", "reason", "cnpj", "created_at", "updated_at", "deleted_at" },
                values: new object[,]
                {
                    { new Guid("d8b6a3b4-0b58-4bfb-8a3f-37f5b2e33dc1"), "Empresa Exemplo LTDA", "12.345.678/0001-90", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), null, null },
                    { new Guid("f3b54699-2cd2-411c-ae6e-08bfb8fbc3b5"), "Tech Solutions S.A.", "98.765.432/0001-09", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), null, null },
                    { new Guid("b8a8a9a7-0c5e-4f34-8b3a-5e23fbc3e67b"), "Comércio do Bairro EIRELI", "22.333.444/0001-55", new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_services_company_id",
                table: "services",
                column: "company_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
