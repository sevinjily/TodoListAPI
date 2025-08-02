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
        public async Task<IActionResult> Add([FromBody] TodoItemDTO item)
        {
          await  _todoItemService.AddAsync(item);
            return Ok("Əlavə olundu");
        }
        [HttpDelete]
        public  IActionResult Delete([FromQuery]Guid id)
        {
             _todoItemService.Delete(id);
            return Ok("Ugurla Silindi");
        }

    }
}
