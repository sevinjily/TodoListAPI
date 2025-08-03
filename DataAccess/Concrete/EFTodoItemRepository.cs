using DataAccess.Abstract;
using Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{

    public class EFTodoItemRepository : ITodoItemRepository

    {
        private readonly TodoDbContext _context;

        public EFTodoItemRepository(TodoDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TodoItem todoItem)
        {
            await _context.TodoItems.AddAsync(todoItem);
            await _context.SaveChangesAsync();
        }

        public void Delete(Guid id)
        {
            var findItem=_context.TodoItems.FirstOrDefault(x=>x.Id==id);
            if (findItem != null)
            {
                _context.TodoItems.Remove(findItem);
             _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Guid id, TodoItem item)
        {
            var findItem =await _context.TodoItems.FirstOrDefaultAsync(x => x.Id == id);
            if(findItem != null)
            {
                findItem.Title = item.Title;
                findItem.IsCompleted = item.IsCompleted;
                findItem.DueDate = item.DueDate;
               await _context.SaveChangesAsync();
            }
        }
        public TodoItem Get(Guid id)
        {
            return _context.TodoItems.FirstOrDefault(x => x.Id == id);
        }

    }
}
