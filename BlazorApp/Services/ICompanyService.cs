using BlazorApp.Models;

namespace BlazorApp.Services
{
    public interface ICompanyService
    {
        Task<List<Company>> GetCompanies();
    }
}