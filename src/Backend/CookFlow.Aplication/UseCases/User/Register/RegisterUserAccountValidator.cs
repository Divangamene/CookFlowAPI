using CookFlow.Communication.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookFlow.Aplication.UseCases.User.Register
{
    public class RegisterUserAccountValidator : AbstractValidator<RequestRegisterUserAccountJson>
    {
    public RegisterUserAccountValidator() {

            RuleFor(User => User.Nome).NotEmpty().WithMessage("O nome não pode ser nulo");
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email nao pode ser nulo");
            RuleFor(user => user.Password).NotEmpty().WithMessage("Password nao pode ser nulo");
            When(user => string.IsNullOrWhiteSpace(user.Email) ==false, () =>
            {
                RuleFor(user => user.Email).EmailAddress().WithMessage("Email deve ser valido");
            });

            



        }
    }
}
