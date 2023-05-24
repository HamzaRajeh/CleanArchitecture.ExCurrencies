using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Domain.Entities;
public class CurrenciesDeletedEvent : BaseEvent
{
    public CurrenciesDeletedEvent(Currencies _currencies)
    {
        Currencies = _currencies;
    }
    public Currencies Currencies { get; set; }
}
