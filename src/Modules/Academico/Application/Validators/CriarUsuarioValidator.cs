using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Modules.Academico.Application.DTOs;

namespace Modules.Academico.Application.Validators;

public class CriarUsuarioValidator : AbstractValidator<UsuarioDto>
{
       public CriarUsuarioValidator()
       {
              RuleFor(entidade => entidade.Nome)
                     .NotEmpty()
                     .MaximumLength(100)
                     .WithMessage("Nome ultrapassou o limite de caracteres.");
              RuleFor(entidade => entidade.Email)
                     .NotEmpty()
                     .EmailAddress()
                     .WithMessage("Não informado em formato de email.");
              RuleFor(entidade => entidade.SenhaHash)
                     .NotEmpty()
                            .WithMessage("A senha é obrigatoria!")
                     .MinimumLength(8)
                            .WithMessage("O tamanho minimo é de 8 digitos")
                     .MaximumLength(128)
                            .WithMessage("Tamanho maximo atingido.")
                     .Must(senha => senha != null && senha.Any(char.IsUpper))
                            .WithMessage("Senha nao preenchida ou não contem caractere maiusculo")
                     .Must(senha => senha != null && senha.Any(char.IsLower))
                            .WithMessage("A senha deve conter pelo menos uma letra minúscula.")
                     .Must(senha => senha != null && senha.Any(char.IsDigit))
                            .WithMessage("A senha deve conter pelo menos um número.")
                     .Must(senha => senha != null && senha.Any(c => !char.IsLetterOrDigit(c)))
                            .WithMessage("A senha deve conter pelo menos um caractere especial.");
              RuleFor(x => x.Cpf)
                      .NotEmpty()
                      .Must(cpf => cpf.All(char.IsDigit))
                      .WithMessage("O CPF deve conter apenas números.")
                      .Length(11)
                      .WithMessage("O CPF deve conter exatamente 11 dígitos.");
       }
}