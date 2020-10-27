using AutoMapper;
using Dto;
using Entity;

namespace WebApplication1
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentDto, StudentEntity>().ReverseMap();
        }
    }
}
