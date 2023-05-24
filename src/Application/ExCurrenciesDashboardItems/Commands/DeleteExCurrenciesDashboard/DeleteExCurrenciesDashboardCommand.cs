using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Exceptions;
using ExCurrency.Application.Common.Interfaces;
using ExCurrency.Domain.Entities;
using MediatR;

namespace ExCurrency.Application.ExCurrenciesDashboardItems.Commands.DeleteExCurrenciesDashboard;
public record DeleteExCurrenciesDashboardCommand : IRequest
{
    public string? ApplicationUserId { get; set; }
    public int? CurrenciesId { get; set; }

}

public class DeleteExCurrenciesDashboardCommandHandler : IRequestHandler<DeleteExCurrenciesDashboardCommand>
{
    public readonly IApplicationDbContext _context; 
    public DeleteExCurrenciesDashboardCommandHandler(IApplicationDbContext context)
    {
        _context = context; 
        
    }
    public async Task<Unit> Handle(DeleteExCurrenciesDashboardCommand request, CancellationToken cancellationToken)
    {

        var id = _context.ExCurrenciesDashboard.Where(a => a.ApplicationUserId == request.ApplicationUserId && a.CurrenciesId == request.CurrenciesId).Select(a => a.Id).FirstOrDefault();

        var entity = await _context.ExCurrenciesDashboard.FindAsync(id, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(ExCurrenciesDashboard), request.ApplicationUserId);
        }

        _context.ExCurrenciesDashboard.Remove(entity);

        entity.AddDomainEvent(new ExCurrenciesDashboardDeletedEvent(entity));

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}