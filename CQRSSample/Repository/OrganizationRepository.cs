// filepath: /CQRSSample/CQRSSample/Repository/OrganizationRepository.cs
using CQRSSample.Models;

namespace CQRSSample.Repository
{
    public class OrganizationRepository : IRepository<Organization>
    {
        private readonly List<Organization> _organizations = new List<Organization>();

        public async Task<Organization> GetByIdAsync(int id)
        {
            return await Task.FromResult(_organizations.Find(org => org.Id == id));
        }

        public async Task<IEnumerable<Organization>> GetAllAsync()
        {
            return await Task.FromResult(_organizations);
        }

        public async Task AddAsync(Organization organization)
        {
            _organizations.Add(organization);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Organization organization)
        {
            await UpdateAsync(organization);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            await DeleteAsync(id);
            
            await Task.CompletedTask;
        }
    }
}