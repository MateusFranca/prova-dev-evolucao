using BlazorApp.Models;
using BlazorApp.Repositories;

namespace BlazorApp.Services.Imp
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public Task<List<Service>> GetServicesAsync()
        {
            return _serviceRepository.GetServicesAsync();
        }

        public Task<Service?> GetServiceAsync(Guid id)
        {
            return _serviceRepository.GetServiceAsync(id);
        }

        public Task AddServiceAsync(Service service)
        {
            return _serviceRepository.AddServiceAsync(service);
        }

        public Task UpdateServiceAsync(Service service)
        {
            return _serviceRepository.UpdateServiceAsync(service);
        }

        public Task DeleteServiceAsync(Guid id)
        {
            return _serviceRepository.DeleteServiceAsync(id);
        }
    }
}