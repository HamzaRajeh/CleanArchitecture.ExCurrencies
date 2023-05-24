using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Domain.Entities;
public class ExCurrenciesDashboardDeletedEvent : BaseEvent
{
    public ExCurrenciesDashboardDeletedEvent(ExCurrenciesDashboard _ExCurrenciesDashboard)
    {
        ExCurrenciesDashboard = _ExCurrenciesDashboard;
    }
    public ExCurrenciesDashboard ExCurrenciesDashboard { get; set; }
}
