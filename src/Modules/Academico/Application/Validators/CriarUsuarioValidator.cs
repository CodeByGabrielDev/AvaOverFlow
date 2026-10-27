using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Modules.Academico.Application.DTOs;

namespace Modules.Academico.Application.Validators;

public class CriarUsuarioValidator : AbstractValidator<UsuarioDto>
{
    public CriarUsuarioValidator()
    {
        RuleFor(entidade=>entidade.Nome)
               .NotEmpty()
               .MaximumLength(100)
               .WithMessage("Nome ultrapassou o limite de caracteres.");
        RuleFor(entidade=>entidade.Email)
               .NotEmpty()
               .EmailAddress()
               .WithMessage("Não informado em formato de email.");
        RuleFor(entidade=>entidade.SenhaHash)
               .NotEmpty()
               .MinimumLength(8);
        RuleFor(x => x.Cpf)
                .NotEmpty()
                .Must(cpf => cpf.All(char.IsDigit))
                .WithMessage("O CPF deve conter apenas números.")
                .Length(11)
                .WithMessage("O CPF deve conter exatamente 11 dígitos.");
    }
}