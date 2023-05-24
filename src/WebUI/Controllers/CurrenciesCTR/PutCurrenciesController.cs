using ExCurrency.Application.CurrencyItems.Commands.updateCurrencies;
using ExCurrency.WebUI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.CurrenciesCTR;
public class PutCurrenciesController : ApiControllerBase
{
    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, UpdateCurrencyCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }


}
