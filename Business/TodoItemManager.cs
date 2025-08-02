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



        public TodoItemManager(ITodoItemRepository todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(TodoItemDTO todoItem)
        {
            var item = _mapper.Map<TodoItem>(todoItem);
            item.CreatedAt = DateTime.Now;
          await  _todoRepository.AddAsync(item);
        }

        public void Delete(Guid id)
        {
             _todoRepository.Delete(id);
        }
    }
}
