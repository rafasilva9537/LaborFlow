using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        var assembly = typeof(DependecyInjection).Assembly;

        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
