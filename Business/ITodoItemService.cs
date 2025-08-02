using Entities.DTO;

namespace Business
{
    public interface ITodoItemService
    {
        Task AddAsync(TodoItemDTO todoItem);
        void Delete(Guid id);
    }
}
