using AutoMapper;
using PROJECTName.Application.DTOs;
using PROJECTName.Domain.Entities;

namespace PROJECTName.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Example, ExampleDTO>().ReverseMap();
        }
    }
}
