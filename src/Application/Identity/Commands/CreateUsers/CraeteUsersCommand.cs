using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ExCurrency.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ExCurrency.Application.Identity.Commands.CreateUsers;
public record CraeteUsersCommand : IRequest<bool>
{
    public string? AccountDescription { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
    public int? BaseCurrencyID { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }


}

public class CraeteUsersCommandHandler : IRequestHandler<CraeteUsersCommand, bool>
{

    public  UserManager<Users> _UserManger;  
     public CraeteUsersCommandHandler(UserManager<Users> UserManger)
    {
        _UserManger = UserManger;
 
        
    }
  public async  Task<bool> Handle(CraeteUsersCommand request, CancellationToken cancellationToken)
    {
        var email=_UserManger.FindByEmailAsync(request.Email);
        //if (email != null) { return "this email is found it"; }
        var UserName = _UserManger.FindByNameAsync(request.UserName)    ;
        //if (UserName != null) { return "this UserName is found it"; }
        var user = new Users() {UserName= request.UserName,Email=request.Email,AccountDescription=request.AccountDescription,PhoneNumber=request.PhoneNumber };
      var result= await _UserManger.CreateAsync(user, request.Password);

        return result.Succeeded;

    }
}
