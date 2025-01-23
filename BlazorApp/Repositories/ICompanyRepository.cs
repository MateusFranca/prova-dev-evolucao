using BlazorApp.Models;

namespace BlazorApp.Repositories
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetCompanies();
        Task<Company?> GetCompanyByIdAsync(Guid id);
    }
}