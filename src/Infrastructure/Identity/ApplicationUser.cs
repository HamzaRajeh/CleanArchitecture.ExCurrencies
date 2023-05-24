using System.ComponentModel.DataAnnotations.Schema;
using ExCurrency.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace ExCurrency.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    [ForeignKey("Currencies")]
    public int? BaseCurrencyID { get; set; }
    public string? AccountDescription { get; set; }
    public ICollection<ExCurrenciesDashboard> ExCurrenciesDashboard { get; } = new List<ExCurrenciesDashboard>();
    public ICollection<ExCurrenciesHistory> ExCurrenciesHistory { get; } = new List<ExCurrenciesHistory>();
    public virtual Currencies Currencies { get;set;}


}
