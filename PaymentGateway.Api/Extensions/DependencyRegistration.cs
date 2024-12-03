using Microsoft.AspNetCore.ResponseCompression;
using PaymentGateway.DataAccess;
using PaymentGateway.Services;

namespace PaymentGateway.Api.Extensions;

public static class DependencyRegistration
{
    public static IServiceCollection AddDependencyServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services
            .AddRepositoryContext(configuration)
            .AddContext()
            .AddRepository()
            .AddService(configuration);
    }

}

