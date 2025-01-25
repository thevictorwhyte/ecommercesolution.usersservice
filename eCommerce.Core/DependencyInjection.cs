using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Core;

public static class DependencyInjection
{
    /// <summary>
    /// Extension method to add core services 
    /// to the dependency injection container.
    /// </summary>
    /// <param name="services">The service collection to add services to.</param>
    /// <returns>The modified service collection.</returns>
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        // To Do: Add services to the IoC container.
        // Core services often include data access, 
        // caching and other low-level components.
        services.AddTransient<IUsersService, UsersService>();
        return services;

    }

}
 