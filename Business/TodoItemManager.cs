using AutoMapper;
using DataAccess.Abstract;
using Entities.DTO;
using Entities.Model;

namespace Business
{
    public class TodoItemManager : ITodoItemService
    {
        private readonly ITodoItemRepository _todoRepository;
        private readonly IMapper _mapper;

        public TodoItemManager(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TodoItemManager(ITodoItemRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public void Add(TodoItemDTO todoItem)
        {
            var item = _mapper.Map<TodoItem>(todoItem);
            _todoRepository.AddAsync(item);  
        }
    }
}
