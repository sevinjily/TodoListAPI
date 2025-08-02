using AutoMapper;
using Entities.DTO;
using Entities.Model;

namespace Business.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoItem, TodoItemDTO>().ReverseMap();
         

        }
    }
}
