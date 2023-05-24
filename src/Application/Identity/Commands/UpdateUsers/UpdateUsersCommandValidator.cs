using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ExCurrency.Application.Identity.Commands.UpdateUsers;
internal class UpdateUsersCommandValidator:AbstractValidator<UpdateUsersCommand>
{
    public UpdateUsersCommandValidator()
    {
        RuleFor(a => a.AccountDescription).NotEmpty();
        RuleFor(a => a.UserName).NotEmpty();

    }
}
