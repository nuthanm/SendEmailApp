using EmailApp.Application.EmailContracts;
using Microsoft.Extensions.DependencyInjection;

namespace EmailApp.Infrastructure.Extensions;
public static class ServiceCollection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddTransient<IEmailService, EmailService>();
        return services;
    }
}
