using Modules.Academico.Application.DTOs;
using Modules.Academico.Application.Interfaces;
using Modules.Academico.Domain.Entities;
using Modules.Academico.Domain.Exceptions;

namespace Modules.Academico.Application.Services;


public class UsuarioService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUsuarioRepository _usuarioRepository;


    public UsuarioService(IUnitOfWork _unitOfWork, IUsuarioRepository _usuarioRepository)
    {
        this._unitOfWork = _unitOfWork;
        this._usuarioRepository = _usuarioRepository;
    }

    public async Task RegistrarUsuario(UsuarioDto usuarioDto)
    {
        Usuario? usuario = await this._usuarioRepository.FindByCpf(usuarioDto.Cpf);
        if(usuario != null) throw new UsuarioJaRegistradoException();

        
        if (usuarioDto.PapelUsuario == Domain.Enums.PapelUsuario.ALUNO)
        {
            Aluno aluno = new Aluno()
        }
    }
}