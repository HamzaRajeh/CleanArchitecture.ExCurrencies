using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Exceptions;
using ExCurrency.Application.Common.Interfaces;
using ExCurrency.Domain.Entities;
using MediatR;

namespace ExCurrency.Application.CurrencyItems.Commands.daleteCurrencies;
public record DeleteCurrenciesCommand(int Id) : IRequest;



public class DeleteCurrenciesCommandHandler : IRequestHandler<DeleteCurrenciesCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteCurrenciesCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteCurrenciesCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Currencies
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Currencies), request.Id);
        }

        _context.Currencies.Remove(entity);

        entity.AddDomainEvent(new CurrenciesDeletedEvent(entity));

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
