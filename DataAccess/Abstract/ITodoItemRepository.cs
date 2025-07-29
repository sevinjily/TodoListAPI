using Entities.DTO;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITodoItemRepository
    {
        Task AddAsync(TodoItem todoItem);
    }
}
