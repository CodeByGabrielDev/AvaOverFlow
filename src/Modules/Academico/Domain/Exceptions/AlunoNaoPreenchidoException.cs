namespace Modules.Academico.Domain.Exceptions;


public class AlunoNaoPreenchidoException : DomainException
{
    public AlunoNaoPreenchidoException():base("Aluno não contem alguma informação previamente preenchida."){}
}