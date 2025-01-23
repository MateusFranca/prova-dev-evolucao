using BlazorApp.Context;
using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Repositories.Imp
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ContextBD _context;

        public ServiceRepository(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Service>> GetServicesAsync()
        {
            return await _context.Services
            .Include(s => s.CompanyId)
            .Where(se => se.DeletedAt == null)
            .ToListAsync();
        }

        public async Task<Service?> GetServiceAsync(Guid id)
        {
            return await _context.Services
            .Include(s => s.CompanyId)
            .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task AddServiceAsync(Service service)
        {

            service.CreatedAt = DateTime.UtcNow;
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateServiceAsync(Service service)
        {
            service.UpdatedAt = DateTime.UtcNow;
            _context.Services.Update(service);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteServiceAsync(Guid id)
        {
            var service = await GetServiceAsync(id);
            if (service != null)
            {
                service.DeletedAt = DateTime.UtcNow;
                _context.Services.Update(service);
                await _context.SaveChangesAsync();
            }
        }
    }
}