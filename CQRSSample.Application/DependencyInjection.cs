using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CQRSSample.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            
            return services;
        }
    }
}