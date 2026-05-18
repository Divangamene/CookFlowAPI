using CookFlow.Communication.Request;
using CookFlow.Exception;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookFlow.Aplication.UseCases.User.Register
{
    public class RegisterUserAccountValidator : AbstractValidator<RequestRegisterUserAccountJson>
    {
    public RegisterUserAccountValidator() {

            RuleFor(User => User.Nome).NotEmpty().WithMessage(ResourceMessagesException.VALIDATION_NAME_REQUIRED);
            RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesException.VALIDATION_EMAIL_REQUIRED);
            RuleFor(user => user.Password).NotEmpty().WithMessage("Password nao pode ser nulo");
            When(user => string.IsNullOrWhiteSpace(user.Email) ==false, () =>
            {
                RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessagesException.VALIDATION_EMAIL_REQUIRED);
            });

            



        }
    }
}
