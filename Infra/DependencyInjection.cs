using Microsoft.EntityFrameworkCore;
using Infra.Data;
using Application.Mappers;

namespace Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FisioDbContext>(options =>
                options.UseMySql(
                    configuration.GetConnectionString("DefaultConnection"),
                    ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection"))
                ));
            services.AddScoped<Infra.Repositories.ICustomerRepository, Infra.Repositories.CustomerRepository>();
            services.AddAutoMapper(typeof(CustomerProfile));
            return services;
        }
    }
}
