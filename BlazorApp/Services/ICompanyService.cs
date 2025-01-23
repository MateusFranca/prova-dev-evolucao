using BlazorApp.Models;

namespace BlazorApp.Services
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompanies();
        Task<Company?> GetCompanyByIdAsync(Guid id);
    }
}