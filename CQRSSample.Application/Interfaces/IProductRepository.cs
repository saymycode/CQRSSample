using CQRSSample.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSSample.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
