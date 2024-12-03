using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.DataAccess;

public static class DependencyRegistration
{
    public static IServiceCollection AddRepositoryContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<PaymentGatewayContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("dbconnection:ConnectionString"), opt => opt.MigrationsAssembly("PaymentGateway.DataAccess"));
        });

        return services;
    }

    public static IServiceCollection AddContext(this IServiceCollection services)
    {
        return services
            .AddScoped<PaymentGatewayContext>();
    }
}
