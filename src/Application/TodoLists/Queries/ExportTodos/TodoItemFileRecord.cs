using ExCurrency.Application.Common.Mappings;
using ExCurrency.Domain.Entities;

namespace ExCurrency.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
