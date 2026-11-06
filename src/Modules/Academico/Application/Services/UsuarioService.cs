using Modules.Academico.Application.DTOs;
using Modules.Academico.Application.Interfaces;
using Modules.Academico.Domain.Entities;
using Modules.Academico.Domain.Enums;
using Modules.Academico.Domain.Exceptions;

namespace Modules.Academico.Application.Services;


public class UsuarioService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IPasswordHasher _passwordHasher;


    public UsuarioService(IPasswordHasher _passwordHasher, IUnitOfWork _unitOfWork, IUsuarioRepository _usuarioRepository, AlunoService alunoService)
    {
        this._unitOfWork = _unitOfWork;
        this._passwordHasher = _passwordHasher;
        this._usuarioRepository = _usuarioRepository;
    }

    public async Task RegistrarUsuario(UsuarioDto usuarioDto)
    {
        Usuario? usuario = await this._usuarioRepository.FindByCpf(usuarioDto.Cpf);
        if (usuario != null) throw new UsuarioJaRegistradoException();
        Usuario usuarioEntity = new Usuario(usuarioDto.Nome, usuarioDto.Email, usuarioDto.Cpf, usuarioDto.Telefone);
        PapelUsuario papelUsuario = usuarioEntity.RetornarTipoDePapelUsuario(usuarioDto.PapelUsuario);
        usuarioEntity.DefinirPapelDoUsuario(papelUsuario);
        if (usuarioDto.SenhaHash == null)
        {
            throw new DomainException("Senha não informada.");
        }
        usuarioEntity.DefinirSenha(this._passwordHasher.Hash(usuarioEntity, usuarioDto.SenhaHash));
        usuarioEntity.CriarVinculoAcademico();
        await this._usuarioRepository.AddAsync(usuarioEntity);
        await this._unitOfWork.SaveChangesAsync();

    }


}