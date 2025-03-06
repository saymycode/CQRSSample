// filepath: /CQRSSample/CQRSSample/Repository/ProductRepository.cs
using CQRSSample.Models;

namespace CQRSSample.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> _products = new List<Product>();

        public async Task AddAsync(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask; // Simulate async operation
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var product = _products.Find(p => p.Id == id);
            return await Task.FromResult(product);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(_products);
        }

        public async Task UpdateAsync(Product product)
        {
            await UpdateAsync(product);
            
            await Task.CompletedTask; // Simulate async operation
        }

        public async Task DeleteAsync(int id)
        {
             await DeleteAsync(id);
           
            await Task.CompletedTask; // Simulate async operation
        }
    }
}