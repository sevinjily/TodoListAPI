using Business;
using Entities.DTO;
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
        public async Task<IActionResult> Add([FromBody] AddTodoItemDTO item)
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
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery]Guid id,[FromBody]UpdateTodoItemDTO item) 
            { 
           await _todoItemService.UpdateAsync(id, item);
            return Ok("Ugurla Yenilendi");
        
        }
        [HttpGet]
        public IActionResult Get([FromQuery] Guid id)
        {
            var result = _todoItemService.Get(id);
            if (result == null) return NotFound();
            return Ok(result);
        }


    }
}
