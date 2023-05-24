using ExCurrency.Application.ExCurrenciesDashboardItems.Commands.UpdateExCurrenciesDashboard;
using ExCurrency.WebUI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.ExDashboardCTR;
public class PutExDashboardController : ApiControllerBase
{
    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, UpdateExCurrenciesDashboardCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }


}
