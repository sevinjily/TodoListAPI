using Entities.DTO;
using Entities.Model;

namespace DataAccess.Abstract
{
    public interface ITodoItemRepository
    {
        Task AddAsync(TodoItem todoItem);
        void Delete(Guid id);
        Task UpdateAsync(Guid id,TodoItem todoItem);
        TodoItem Get(Guid id);


    }
}
