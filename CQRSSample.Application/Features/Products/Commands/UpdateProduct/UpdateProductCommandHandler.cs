using CQRSSample.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSSample.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            if (product == null)
                return false;

            product.ProductCode = request.ProductCode;
            product.Description = request.Description;
            product.Consumption = request.Consumption;
            product.ComunicationType = request.ComunicationType;
            product.UpdatedAt =   DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
