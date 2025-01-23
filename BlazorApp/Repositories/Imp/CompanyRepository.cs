using BlazorApp.Context;
using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Repositories.Imp
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ContextBD _context;

        public CompanyRepository(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Company>> GetCompanies()
        {
            return await _context.Companies
            .Include(c => c.Services)
            .ToListAsync();
        }

        public async Task<Company?> GetCompanyByIdAsync(Guid id)
        {
            return await _context.Companies
                .Include(c => c.Services)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}