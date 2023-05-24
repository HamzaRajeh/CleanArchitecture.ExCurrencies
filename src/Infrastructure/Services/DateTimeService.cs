using ExCurrency.Application.Common.Interfaces;

namespace ExCurrency.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
