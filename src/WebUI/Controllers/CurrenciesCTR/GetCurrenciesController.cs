using ExCurrency.Application.Common.Models;
using ExCurrency.Application.CurrencyItems.Queries.GetCurrencies;
using ExCurrency.Domain.Entities;
using ExCurrency.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.CurrenciesCTR;

public class GetCurrenciesController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<PaginatedList<CurrenciesDTO>>> GetCurrenciesWithPagination([FromQuery] GetCurrenciesWithPaginationQuery query)
    {
        return await Mediator.Send(query);
    }
}
