using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using FluentValidation;

namespace ExCurrency.Application.CurrencyItems.Commands.createCurrencies;
public class UpdateCurrencyCommandValidator:AbstractValidator<CreateCurrencyCommand>  
{
    public UpdateCurrencyCommandValidator()
    {
        RuleFor(a=>a.country).NotEmpty();
        RuleFor(a=>a.code).NotEmpty();
        RuleFor(a=>a.symbol).NotEmpty();
        RuleFor(a=>a.currencyNameAr).NotEmpty();
        RuleFor(a=>a.currencyName).NotEmpty();
    }
}
