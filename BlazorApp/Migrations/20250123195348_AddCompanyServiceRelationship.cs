using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace BlazorApp.Migrations
{
    public partial class AddCompanyServiceRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "services",
                type: "uuid",
                nullable: false,
                defaultValue: Guid.Empty);

            migrationBuilder.CreateIndex(
                name: "IX_services_CompanyId",
                table: "services",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_services_companies_CompanyId",
                table: "services",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_companies_CompanyId",
                table: "services");

            migrationBuilder.DropIndex(
                name: "IX_services_CompanyId",
                table: "services");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "services");
        }
    }
}
