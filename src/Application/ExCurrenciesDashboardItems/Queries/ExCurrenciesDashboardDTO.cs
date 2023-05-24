using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Mappings;
using ExCurrency.Domain.Entities;

namespace ExCurrency.Application.ExCurrenciesDashboardItems.Queries;
public class ExCurrenciesDashboardDTO:IMapFrom<ExCurrenciesDashboard>
{
    public int? CurrenciesId { get; set; }
    public decimal BuyRate { get; set; } = 0;
    public decimal SaleRate { get; set; } = 0;
    public string? ApplicationUserId { get; set; }
}
