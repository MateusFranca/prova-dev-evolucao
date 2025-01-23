using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorApp.Context
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options) { }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Service>()
                .HasOne<Company>()
                .WithMany(c => c.Services)
                .HasForeignKey(s => s.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed Data para a tabela companies
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = Guid.Parse("d8b6a3b4-0b58-4bfb-8a3f-37f5b2e33dc1"),
                    Reason = "Empresa Exemplo LTDA",
                    CNPJ = "12.345.678/0001-90",
                    CreatedAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new Company
                {
                    Id = Guid.Parse("f3b54699-2cd2-411c-ae6e-08bfb8fbc3b5"),
                    Reason = "Tech Solutions S.A.",
                    CNPJ = "98.765.432/0001-09",
                    CreatedAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new Company
                {
                    Id = Guid.Parse("b8a8a9a7-0c5e-4f34-8b3a-5e23fbc3e67b"),
                    Reason = "Comércio do Bairro EIRELI",
                    CNPJ = "22.333.444/0001-55",
                    CreatedAt = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }
    }
}

