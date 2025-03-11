using Microsoft.EntityFrameworkCore;
using CQRSSample.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}