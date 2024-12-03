using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaymentGateway.DataAccess;
using PaymentGateway.Services.Repository;
using PaymentGateway.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway.Services
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            return services
                .AddScoped<ITodoRepository>();
        }

        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddScoped<TodoService>();
        }
    }
}
