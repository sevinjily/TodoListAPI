using Business;
using Entities.DTO;
using Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        [HttpPost]
        public IActionResult Add([FromBody] TodoItemDTO item)
        {
            _todoItemService.Add(item);
            return Ok("Əlavə olundu");
        }

    }
}
