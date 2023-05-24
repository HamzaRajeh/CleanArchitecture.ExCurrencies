using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExCurrency.Domain.Entities;
public class ExCurrenciesHistory : BaseAuditableEntity
{

    public int? CurrencyId { get; set; }
    public decimal BuyRate { get; set; } = 0;
    public decimal SaleRate { get; set; }
    public string? UsersId { get; set; }
    public virtual Currencies? Currency { get; set;} 

}
