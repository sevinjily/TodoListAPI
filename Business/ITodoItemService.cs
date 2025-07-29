using Entities.DTO;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ITodoItemService
    {
        void Add(TodoItemDTO todoItem);
    }
}
