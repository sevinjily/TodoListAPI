using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class TodoItemDTO
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
