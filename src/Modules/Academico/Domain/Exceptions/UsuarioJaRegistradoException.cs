namespace Modules.Academico.Domain.Exceptions;


public class UsuarioJaRegistradoException : DomainException
{
    public UsuarioJaRegistradoException():base("Usuario ja registrado com essas informações"){}
}