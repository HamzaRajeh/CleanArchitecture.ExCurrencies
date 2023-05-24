using ExCurrency.Application.Identity.Commands.Signin;
using ExCurrency.WebUI.Controllers;
 using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers.Identity.Signin;
 
public class LoginController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<dynamic>> Login(LoginCommand command)
    {

        return await Mediator.Send(command);
    }
}
