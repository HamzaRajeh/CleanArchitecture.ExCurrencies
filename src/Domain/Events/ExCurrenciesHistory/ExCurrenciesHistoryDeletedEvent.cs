using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Domain.Entities;
public class ExCurrenciesHistoryDeletedEvent : BaseEvent
{
    public ExCurrenciesHistoryDeletedEvent(ExCurrenciesHistory _ExCurrenciesHistory)
    {
        ExCurrenciesHistory = _ExCurrenciesHistory;
    }
    public ExCurrenciesHistory ExCurrenciesHistory { get; set; }
}
