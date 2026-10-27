using Microsoft.Extensions.DependencyInjection;
using Modules.Academico.Application.Services;

namespace Modules.Academico.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<AlunoService>();

        return services;
    }
}