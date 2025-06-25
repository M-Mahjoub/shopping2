using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Domain.Abstractions;
using Ordering.Infrastructure.Repositories;

namespace Ordering.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(context =>
                    context.UseNpgsql(configuration.GetConnectionString("OrderingConnectionString")));

            services.AddScoped<IOrderRepository, OrderRepository>();
            //services.Configure<EmaillSetting>(c => configuration.GetConnectionString("EmailSetting"));

            return services;
        }
    }
}
