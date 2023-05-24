using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ExCurrency.Application.Identity.Commands.Signin;
public class LoginCommand:IRequest<Users>
{
    public string username{ get; set; }
    public string password{ get; set; }
}

public class LoginCommandHandler : IRequestHandler<LoginCommand, Users>
{

    private readonly SignInManager<Users> _SignInManager;
    private readonly UserManager<Users> _UserManager;
    public LoginCommandHandler(SignInManager<Users> SignInManager, UserManager<Users> userManager)
    {
        _SignInManager = SignInManager;
        _UserManager = userManager; 

    }

    public async Task<Users> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var Result = await _SignInManager.PasswordSignInAsync(request.username, request.password, false, false);
        if (Result.Succeeded) {

            var user = await _UserManager.FindByNameAsync(request.username);

            if (user != null) { 
            _UserManager.CreateSecurityTokenAsync(user);
            }

            return user; }

        return null;

    
    }
}
