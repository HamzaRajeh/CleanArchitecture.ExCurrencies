using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExCurrency.Domain.Entities;
public class ExCurrenciesDashboard : BaseAuditableEntity
{
   
    public int? CurrenciesId { get; set; }
    public decimal BuyRate { get; set; } = 0;
    public decimal SaleRate { get; set; }=0;
    public  string? ApplicationUserId { get;set; }
    public List<Currencies>? Currencies { get; set; }
}
