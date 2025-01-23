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
            return await _context.Companies.ToListAsync();
        }
    }
}