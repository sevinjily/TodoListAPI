using DataAccess.Abstract;
using Entities.DTO;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
