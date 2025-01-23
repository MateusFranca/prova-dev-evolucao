using BlazorApp.Models;

namespace BlazorApp.Services
{
    public interface IServiceService
    {
        Task<List<Service>> GetServicesAsync();
        Task<Service?> GetServiceAsync(Guid id);
        Task AddServiceAsync(Service service);
        Task UpdateServiceAsync(Service service);
        Task DeleteServiceAsync(Guid id);
    }
}