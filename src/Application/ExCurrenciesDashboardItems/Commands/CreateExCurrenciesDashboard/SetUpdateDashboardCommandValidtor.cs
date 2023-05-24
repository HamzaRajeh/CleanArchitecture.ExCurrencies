using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ExCurrency.Application.ExCurrenciesDashboardItems.Commands.CreateExCurrenciesDashboard;
internal class CreateExDashboardCommandValidtor:AbstractValidator<SetUpdateDashboardCommand>
{
    public CreateExDashboardCommandValidtor()
    {
        RuleFor(a => a.CurrenciesId).NotEmpty();
        RuleFor(a => a.ApplicationUserId).NotEmpty();
        RuleFor(a => a.SaleRate).NotEmpty();
        RuleFor(a => a.BuyRate).NotEmpty();
    }
}
