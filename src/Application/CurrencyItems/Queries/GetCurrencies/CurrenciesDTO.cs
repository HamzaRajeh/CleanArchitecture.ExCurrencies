using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Application.Common.Mappings;

namespace ExCurrency.Domain.Entities;
public class CurrenciesDTO : IMapFrom<Currencies>
{
    public string? Id { get; set; }
    public string? country { get; set; }
    public string? currencyName { get; set; }
    public string? currencyNameAr { get; set; }
    public string? code { get; set; }
    public string? symbol { get; set; }
    List<ExCurrenciesDashboard> ExCurrenciesDashboard = new List<ExCurrenciesDashboard>();
}
