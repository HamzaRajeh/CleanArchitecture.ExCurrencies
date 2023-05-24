using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Exceptions;
using ExCurrency.Application.Common.Interfaces;
using ExCurrency.Domain.Entities;
using MediatR;

namespace ExCurrency.Application.ExCurrenciesDashboardItems.Commands.UpdateExCurrenciesDashboard;
public class UpdateExCurrenciesDashboardCommand:IRequest
{
    public int? Id { get; set; }

    public int? CurrenciesId { get; set; }
    public decimal BuyRate { get; set; } = 0;
    public decimal SaleRate { get; set; } = 0;
    public string? ApplicationUserId { get; set; }
}

public class UpdateExDashboardCommandHandler : IRequestHandler<UpdateExCurrenciesDashboardCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateExDashboardCommandHandler(IApplicationDbContext context)
    {
        _context = context; 
        
    }

    public async Task<Unit> Handle(UpdateExCurrenciesDashboardCommand request, CancellationToken cancellationToken)
    {

        var entity = await _context.ExCurrenciesDashboard
       .FindAsync(new object[] { request.Id , request.ApplicationUserId,request.CurrenciesId }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(ExCurrenciesDashboard), request.Id);
        }
        entity.BuyRate = request.BuyRate;   
        entity.SaleRate = request.SaleRate; 
        await _context.SaveChangesAsync(cancellationToken);

        var entityH = new ExCurrenciesHistory
        {
            CurrencyId = request.CurrenciesId,
            BuyRate = request.BuyRate,
            SaleRate = request.SaleRate,
            UsersId = request.ApplicationUserId,
        };


        entityH.AddDomainEvent(new ExCurrenciesHistoryCreatedEvent(entityH));
        _context.ExCurrenciesHistory.Add(entityH);

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;



    }
}
