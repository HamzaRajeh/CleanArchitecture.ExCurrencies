 using ExCurrency.Application.Identity.Commands.CreateUsers;
using ExCurrency.WebUI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Identity;

public class CreateUserController : ApiControllerBase
{

    [HttpPost]
    public async Task<ActionResult<dynamic>> Create(CraeteUsersCommand command)
    {
        return await Mediator.Send(command);
    }
}
