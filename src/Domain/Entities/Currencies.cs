using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Domain.Entities.Identity;

namespace ExCurrency.Domain.Entities;
public class Currencies: BaseAuditableEntity
{
   
    public string? country { get; set; }
    public string? currencyName { get; set; }
    public string? currencyNameAr { get; set; }
    public string? code { get; set; }
    public string? symbol { get; set; }
    private bool _done;
    public bool Done
    {
        get => _done;
        set
        {
            if (value == true && _done == false)
            {
                AddDomainEvent(new CurrenciesCompletedEvent(this));
            }

            _done = value;
        }
    }
    public ICollection<ExCurrenciesDashboard> ExCurrenciesDashboard  { get; } = new List<ExCurrenciesDashboard>() ;    
    public ICollection<ExCurrenciesHistory> ExCurrenciesHistory { get; } = new List<ExCurrenciesHistory>();
    public ICollection<Users> Users { get; } = new List<Users>();
}
