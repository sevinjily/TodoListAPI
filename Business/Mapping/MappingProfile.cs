using AutoMapper;
using Entities.DTO;
using Entities.Model;

namespace Business.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoItem, AddTodoItemDTO>().ReverseMap();
            CreateMap<UpdateTodoItemDTO, TodoItem>()
     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.Now))
     .ForMember(dest => dest.CreatedAt, opt => opt.Ignore()); // <-- bu vacibdir!



        }
    }
}
