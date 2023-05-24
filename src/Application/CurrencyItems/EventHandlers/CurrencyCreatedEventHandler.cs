using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.TodoItems.EventHandlers;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ExCurrency.Application.CurrencyItems.EventHandlers;
internal class CurrencyCreatedEventHandler : INotificationHandler<CurrenciesCreatedEvent>
{
    private readonly ILogger<CurrencyCreatedEventHandler> _logger;
    public CurrencyCreatedEventHandler(ILogger<CurrencyCreatedEventHandler> logger)
    {
        _logger = logger;   
    }

    public Task Handle(CurrenciesCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("ExCurrency Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;  

    }
}
