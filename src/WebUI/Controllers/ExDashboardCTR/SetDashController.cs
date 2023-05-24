using ExCurrency.Application.ExCurrenciesDashboardItems.Commands.CreateExCurrenciesDashboard;
using ExCurrency.WebUI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.ExDashboardCTR;
public class SetUpdateDashboardController : ApiControllerBase
{

    [HttpPost]
    public async Task<ActionResult<int>> Create(SetUpdateDashboardCommand command)
    {
        return await Mediator.Send(command);
    }
}
