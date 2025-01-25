using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Infrastructure;

public static class DependencyInjection
{
    /// <summary>
    /// Extension method to add infrastructure services 
    /// to the dependency injection container.
    /// </summary>
    /// <param name="services">The service collection to add services to.</param>
    /// <returns>The modified service collection.</returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // To Do: Add services to the IoC container.
        // Infrastructure services often include data access, 
        // caching and other low-level components.
        services.AddSingleton<IUsersRepository, UsersRepository>();
        return services;

    }

}
 