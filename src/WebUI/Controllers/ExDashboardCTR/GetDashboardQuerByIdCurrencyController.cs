using ExCurrency.Application.Common.Models;
using ExCurrency.Application.ExCurrenciesDashboardItems.Queries.GetExCurrenciesDashboard;
using ExCurrency.Application.ExCurrenciesDashboardItems.Queries;
using ExCurrency.WebUI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.ExDashboardCTR;

public class GetDashboardQuerByIdCurrencyController : ApiControllerBase
{


    [HttpGet]
    public async Task<ActionResult<PaginatedList<ExCurrenciesDashboardDTO>>> GetDashboardQuerById([FromQuery] GetDashboardQuerByIdCurrency query)
    {
        return await Mediator.Send(query);
    }
}
