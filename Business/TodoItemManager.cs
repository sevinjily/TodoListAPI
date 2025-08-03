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

        public async Task AddAsync(AddTodoItemDTO todoItem)
        {
            var item = _mapper.Map<TodoItem>(todoItem);
            item.CreatedAt = DateTime.Now;
            item.UpdatedAt = DateTime.Now;
          await  _todoRepository.AddAsync(item);
        }

        public void Delete(Guid id)
        {
             _todoRepository.Delete(id);
        }

        public TodoItemDTO Get(Guid id)
        {
            var item = _todoRepository.Get(id);
            if (item == null) return null;

            return new TodoItemDTO
            {
                //Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                IsCompleted = item.IsCompleted,
                CreatedAt = item.CreatedAt,
                UpdatedAt = item.UpdatedAt,
                DueDate = item.DueDate
            };
        }


        public async Task UpdateAsync(Guid id, UpdateTodoItemDTO addTodoItem)
        {
            var item =  _mapper.Map<TodoItem>(addTodoItem);
            item.UpdatedAt = DateTime.Now;

            await _todoRepository.UpdateAsync(id,item);
        }
    }
}
