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
    [ForeignKey("Currencies")]
    public int? BaseCurrencyID { get; set; }
    public string? AccountDescription { get; set; }
    public ICollection<ExCurrenciesDashboard> ExCurrenciesDashboard { get; } = new List<ExCurrenciesDashboard>();
    public ICollection<ExCurrenciesHistory> ExCurrenciesHistory { get; } = new List<ExCurrenciesHistory>();
    public virtual Currencies Currencies { get; set; }
}
