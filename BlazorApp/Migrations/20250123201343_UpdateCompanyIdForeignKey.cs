using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    public partial class UpdateCompanyIdForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Renomear a coluna para "company_id"
            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "services",
                newName: "company_id");

            // Renomear o índice para refletir o novo nome da coluna
            migrationBuilder.RenameIndex(
                name: "IX_services_CompanyId",
                table: "services",
                newName: "IX_services_company_id");

            // Ajustar a chave estrangeira para usar "company_id"
            migrationBuilder.AddForeignKey(
                name: "FK_services_companies_company_id",
                table: "services",
                column: "company_id",
                principalTable: "companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverter a chave estrangeira para "CompanyId"
            migrationBuilder.DropForeignKey(
                name: "FK_services_companies_company_id",
                table: "services");

            // Reverter o nome do índice
            migrationBuilder.RenameIndex(
                name: "IX_services_company_id",
                table: "services",
                newName: "IX_services_CompanyId");

            // Reverter o nome da coluna
            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "services",
                newName: "CompanyId");

            // Recriar a chave estrangeira original
            migrationBuilder.AddForeignKey(
                name: "FK_services_companies_CompanyId",
                table: "services",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
