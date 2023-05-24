using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ExCurrency.Application.ExCurrenciesDashboardItems.EventHandlers;
internal class ExDashboardCompletedEventHandler : INotificationHandler<ExCurrenciesDashboardCompletedEvent>
{
    private readonly ILogger<ExDashboardCompletedEventHandler> _logger;
    public ExDashboardCompletedEventHandler(ILogger<ExDashboardCompletedEventHandler> logger)
    {
        _logger = logger;
    }
    public Task Handle(ExCurrenciesDashboardCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("ExCurrency Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;  

    }
}
