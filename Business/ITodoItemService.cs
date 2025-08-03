using Entities.DTO;
using Entities.Model;

namespace Business
{
    public interface ITodoItemService
    {
        Task AddAsync(AddTodoItemDTO todoItem);
        void Delete(Guid id);
        Task UpdateAsync(Guid id, UpdateTodoItemDTO todoItem);
        TodoItemDTO Get(Guid id);
    }
}
