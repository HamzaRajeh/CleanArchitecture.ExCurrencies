using ExCurrency.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExCurrency.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    DbSet<Currencies> Currencies { get; }
    DbSet<ExCurrenciesDashboard> ExCurrenciesDashboard { get; }
    DbSet<ExCurrenciesHistory> ExCurrenciesHistory { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
