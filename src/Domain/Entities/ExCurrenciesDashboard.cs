using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Domain.Entities.Identity;

namespace ExCurrency.Domain.Entities;
public class ExCurrenciesDashboard : BaseAuditableEntity
{
    public int? CurrenciesId { get; set; }
    public decimal BuyRate { get; set; } = 0;
    public decimal SaleRate { get; set; }=0;
    [ForeignKey("Users")]
    public  string? ApplicationUserId { get;set; }
    public List<Currencies>? Currencies { get; set; }
    public virtual Users Users { get; set; }
}
