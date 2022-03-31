
using AutoMapper;
using NajotTalimUoW.Domain.Entities.Students;
using NajotTalimUoW.Service.DTOs.Students;

namespace NajotTalimUoW.Service.Mappers

{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentForCreationDto, Student>().ReverseMap();
        }
    }
}
