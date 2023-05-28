using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ExCurrency.Domain.Entities.Identity;
public class Users: IdentityUser
{
    public string? AccountDescription { get; set; }
    public string? POSTURL { get; set; }
 }
