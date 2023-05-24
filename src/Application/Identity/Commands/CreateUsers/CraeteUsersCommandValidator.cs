using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ExCurrency.Application.Identity.Commands.CreateUsers;
internal class CraeteUsersCommandValidator:AbstractValidator<CraeteUsersCommand>
{
    public CraeteUsersCommandValidator()
    {
        RuleFor(a => a.AccountDescription).NotEmpty();
        RuleFor(a => a.UserName).NotEmpty();
        RuleFor(a => a.Password).NotEmpty();
        RuleFor(a => a.ConfirmPassword).NotEmpty();
    }
}
