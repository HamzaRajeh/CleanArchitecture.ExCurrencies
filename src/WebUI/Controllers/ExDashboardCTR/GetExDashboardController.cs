using ExCurrency.Application.Common.Models;
using ExCurrency.Application.CurrencyItems.Queries.GetCurrencies;
using ExCurrency.Application.ExCurrenciesDashboardItems.Queries;
using ExCurrency.Application.ExCurrenciesDashboardItems.Queries.GetExCurrenciesDashboard;
using ExCurrency.Domain.Entities;
using ExCurrency.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.ExDashboardCTR;

public class GetExDashboardController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<PaginatedList<ExCurrenciesDashboardDTO>>> GetCurrenciesWithPagination([FromQuery] GetDashboardWithPaginationQuer query)
    {
        return await Mediator.Send(query);
    }
}
