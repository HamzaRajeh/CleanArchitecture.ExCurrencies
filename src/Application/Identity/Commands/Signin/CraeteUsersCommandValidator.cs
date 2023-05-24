using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ExCurrency.Application.Identity.Commands.Signin;
internal class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(a => a.username).NotEmpty();
        RuleFor(a => a.password).NotEmpty();
    }
}
