using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Interfaces;
using ExCurrency.Domain.Entities;
using MediatR;

namespace ExCurrency.Application.CurrencyItems.Commands.createCurrencies;
public class CreateCurrencyCommand : IRequest<int>
{

    public string? country { get; set; }
    public string? currencyName { get; set; }
    public string? currencyNameAr { get; set; }
    public string? code { get; set; }
    public string? symbol { get; set; }

}

public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateCurrencyCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var entity = new Currencies
        {
            code = request.code,
            symbol = request.symbol,
            country = request.country,
            currencyName = request.currencyName,
            currencyNameAr = request.currencyNameAr

        };
        entity.AddDomainEvent(new CurrenciesCreatedEvent(entity));
        _context.Currencies.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);
        return entity.Id;
    }
}

