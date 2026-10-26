namespace Modules.Academico.Domain.Exceptions;


public class AlunoNaoEncontradoException : DomainException
{
    public AlunoNaoEncontradoException():base("Aluno nao encontrado Exception, valide a informação enviada como identificador."){}
}