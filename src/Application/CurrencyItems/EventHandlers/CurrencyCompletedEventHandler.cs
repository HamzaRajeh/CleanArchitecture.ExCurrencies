using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.TodoItems.EventHandlers;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ExCurrency.Application.CurrencyItems.EventHandlers;
internal class CurrencyCompletedEventHandler : INotificationHandler<CurrenciesCompletedEvent>
{
    private readonly ILogger<CurrencyCompletedEventHandler> _logger;
    public CurrencyCompletedEventHandler(ILogger<CurrencyCompletedEventHandler> logger)
    {
        _logger = logger;
    }
    public Task Handle(CurrenciesCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("ExCurrency Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;  

    }
}
