using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.TodoItems.EventHandlers;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ExCurrency.Application.ExCurrenciesDashboardItems.EventHandlers;
internal class ExDashboardCreatedEventHandler : INotificationHandler<ExCurrenciesDashboardCreatedEvent>
{
    private readonly ILogger<ExDashboardCreatedEventHandler> _logger;
    public ExDashboardCreatedEventHandler(ILogger<ExDashboardCreatedEventHandler> logger)
    {
        _logger = logger;   
    }

    public Task Handle(ExCurrenciesDashboardCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("ExCurrency Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;  

    }
}
