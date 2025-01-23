using BlazorApp.Models;
using BlazorApp.Repositories;

namespace BlazorApp.Services.Imp
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Task<List<Company>> GetCompanies()
        {
            return _companyRepository.GetCompanies();
        }

        public Task<Company?> GetCompanyByIdAsync(Guid id)
        {
            return _companyRepository.GetCompanyByIdAsync(id);
        }
    }
}