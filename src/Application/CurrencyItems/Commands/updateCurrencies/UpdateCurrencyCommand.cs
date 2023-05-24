using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Exceptions;
using ExCurrency.Application.Common.Interfaces;
using ExCurrency.Domain.Entities;
using MediatR;

namespace ExCurrency.Application.CurrencyItems.Commands.updateCurrencies;
public class UpdateCurrencyCommand : IRequest
{
    public int Id { get; init; }
    public string? country { get; set; }
    public string? currencyName { get; set; }
    public string? currencyNameAr { get; set; }
    public string? code { get; set; }
    public string? symbol { get; set; }
    public bool Done { get; init; }


}


public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateCurrencyCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
    {

        var entity = await _context.Currencies
       .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Currencies), request.Id);
        }
        entity.code = request.code; entity.symbol = request.symbol;
        entity.currencyName = request.currencyName; entity.currencyNameAr = request.currencyNameAr;
        entity.Done = request.Done;
        entity.country = request.country;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}

