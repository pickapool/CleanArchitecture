using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddinfrastructureLayer(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        return services;
    }
}
