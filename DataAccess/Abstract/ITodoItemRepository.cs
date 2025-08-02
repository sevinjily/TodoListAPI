using Entities.Model;

namespace DataAccess.Abstract
{
    public interface ITodoItemRepository
    {
        Task AddAsync(TodoItem todoItem);
        void Delete(Guid id);
    }
}
