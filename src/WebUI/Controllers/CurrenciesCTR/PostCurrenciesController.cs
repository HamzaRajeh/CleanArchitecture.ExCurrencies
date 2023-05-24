using ExCurrency.Application.CurrencyItems.Commands.createCurrencies;
using ExCurrency.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.CurrenciesCTR;
public class PostCurrenciesController : ApiControllerBase
{

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateCurrencyCommand command)
    {
        return await Mediator.Send(command);
    }
}
