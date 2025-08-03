namespace Entities.DTO
{
    public class AddTodoItemDTO
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
