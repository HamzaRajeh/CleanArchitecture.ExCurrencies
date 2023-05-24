  using ExCurrency.Application.Identity.Commands.UpdateUsers;
using ExCurrency.WebUI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Identity;

public class UpdateUserController : ApiControllerBase
{

    [HttpPost]
    public async Task<ActionResult<dynamic>> Create(UpdateUsersCommand command)
    {
        return await Mediator.Send(command);
    }
}
