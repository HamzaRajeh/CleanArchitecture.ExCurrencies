using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ExCurrency.Application.CurrencyItems.Queries.GetCurrencies;
public class GetCurrenciesWithPaginationQueryValidator:AbstractValidator<GetCurrenciesWithPaginationQuery>
{


    public GetCurrenciesWithPaginationQueryValidator()
    {
        RuleFor(x => x.PageNumber)
           .GreaterThanOrEqualTo(1).WithMessage("PageNumber at least greater than or equal to 1.");

        RuleFor(x => x.PageSize)
                .GreaterThanOrEqualTo(1).WithMessage("PageSize at least greater than or equal to 1.");
    }
}
