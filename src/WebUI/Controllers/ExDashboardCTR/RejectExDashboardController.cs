using System.Xml.Serialization;
using CsvHelper.Configuration.Attributes;
using ExCurrency.Application.ExCurrenciesDashboardItems.Commands.DeleteExCurrenciesDashboard;
using ExCurrency.WebUI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.ExDashboardCTR;

public class RejectExDashboardController : ApiControllerBase
{
    [HttpDelete]
    public async Task<ActionResult> Delete(DeleteExCurrenciesDashboardCommand command)
    {
        await Mediator.Send(command);

        return NoContent();
    }
}
