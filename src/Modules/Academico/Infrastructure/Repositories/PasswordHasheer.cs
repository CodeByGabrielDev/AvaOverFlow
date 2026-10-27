using Microsoft.AspNetCore.Identity;
using Modules.Academico.Application.Interfaces;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Security;

public class PasswordHasheer : IPasswordHasher
{
    private readonly Microsoft.AspNetCore.Identity.IPasswordHasher<Usuario>
        _hasher = new Microsoft.AspNetCore.Identity.PasswordHasher<Usuario>();

    public string Hash(Usuario usuario, string password)
{
    return _hasher.HashPassword(usuario, password);
}

    public bool Verify(string password, string passwordHash)
    {
        var usuario = new Usuario();

        var result = _hasher.VerifyHashedPassword(
            usuario,
            passwordHash,
            password
        );

        return result != PasswordVerificationResult.Failed;
    }
}