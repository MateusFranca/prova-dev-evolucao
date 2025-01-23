using BlazorApp.Models;

namespace BlazorApp.Repositories
{
    public interface IServiceRepository
    {
        Task<List<Service>> GetServicesAsync();
        Task<Service?> GetServiceAsync(Guid id);
        Task AddServiceAsync(Service service);
        Task UpdateServiceAsync(Service service);
        Task DeleteServiceAsync(Guid id);
    }
}