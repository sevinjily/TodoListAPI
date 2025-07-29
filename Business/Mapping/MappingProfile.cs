using AutoMapper;
using Entities.DTO;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
