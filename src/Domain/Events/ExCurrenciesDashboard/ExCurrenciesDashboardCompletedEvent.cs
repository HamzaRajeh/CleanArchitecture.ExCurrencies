﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExCurrency.Domain.Entities;
public class ExCurrenciesDashboardCompletedEvent : BaseEvent
{
    public ExCurrenciesDashboardCompletedEvent(ExCurrenciesDashboard _ExCurrenciesDashboard)
    {
        ExCurrenciesDashboard = _ExCurrenciesDashboard;
    }
    public ExCurrenciesDashboard ExCurrenciesDashboard { get; set; }
}
