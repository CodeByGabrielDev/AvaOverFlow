using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Modules.Academico.Application.Interfaces;
using Modules.Academico.Infrastructure.Security;
using Modules.Infrastructure.Persistence.Repositories;
using Modules.Infrastructure.Repositories;

namespace Modules.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddScoped<IAlunoRepository, AlunoRepository>();
        services.AddScoped<IUsuarioRepository,UsuarioRepository>();
        services.AddScoped<IUnitOfWork,UnitOfWork>();
        services.AddScoped<IPasswordHasher,PasswordHasheer>();
        return services;
    }
}