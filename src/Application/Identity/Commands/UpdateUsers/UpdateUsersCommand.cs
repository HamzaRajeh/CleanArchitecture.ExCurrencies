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

namespace ExCurrency.Application.Identity.Commands.UpdateUsers;
public record UpdateUsersCommand : IRequest<Users>
{
    public string? Id { get; set; }
    public string? AccountDescription { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }


}

public class UpdateUsersCommandHandler : IRequestHandler<UpdateUsersCommand, Users>
{

    public  UserManager<Users> _UserManger;  
     public UpdateUsersCommandHandler(UserManager<Users> UserManger)
    {
        _UserManger = UserManger;
 
        
    }
  public async  Task<Users> Handle(UpdateUsersCommand request, CancellationToken cancellationToken)
    {
        var OldUser=await _UserManger.FindByIdAsync(request.Id);
        if (OldUser == null) { return null; }
        var UpdateUser = new Users() { };
        UpdateUser.Id = request.Id; 
        UpdateUser.Email = request.Email;  
        UpdateUser.PhoneNumber = request.PhoneNumber;   
        UpdateUser.UserName = request.UserName; 

        var result= await _UserManger.UpdateAsync(UpdateUser);   
       
        if (result.Succeeded) { 
        return UpdateUser;
        }
        else
        {
            return null;
        }
    }
}
