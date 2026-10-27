using Modules.Academico.Application.Interfaces;
using Modules.Academico.Domain.Entities;
using Modules.Academico.Domain.Exceptions;
using Modules.Infrastructure.Repositories;

namespace Modules.Academico.Application.Services;



public class AlunoService
{
    private readonly IAlunoRepository _alunoRepository;
    public AlunoService(AlunoRepository _alunoRepository)
    {
        this._alunoRepository = _alunoRepository;   
    }

    public async Task RegisterStudent(Aluno aluno)
    {
        if (aluno == null || aluno.Usuario == null || aluno?.IdUsuario == null) throw new AlunoNaoPreenchidoException();
        await this._alunoRepository.AddAsync(aluno);
    }

    public async Task<Aluno?> BuscaAlunoPorId(Guid IdAluno)
    {
        Aluno? aluno = await this._alunoRepository.FindById(IdAluno);
        if (aluno == null) throw new AlunoNaoEncontradoException();
        return aluno;
    }



    
}