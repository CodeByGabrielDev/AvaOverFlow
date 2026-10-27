using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Application.Interfaces;


public interface IPasswordHasher
{
    string Hash(Usuario usuario,string password);

    bool Verify(string password, string passwordHash);
}