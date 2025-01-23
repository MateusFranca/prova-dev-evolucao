using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Context
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options) : base(options) { }
        public DbSet<Company> Companies { get; set; }
    }
}