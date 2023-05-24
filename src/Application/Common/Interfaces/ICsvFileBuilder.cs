using ExCurrency.Application.TodoLists.Queries.ExportTodos;

namespace ExCurrency.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
