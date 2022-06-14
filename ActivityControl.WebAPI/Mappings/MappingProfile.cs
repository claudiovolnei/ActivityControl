using ActivityControl.Domain.Dto.Dto;
using ActivityControl.Domain.Models;
using AutoMapper;

namespace ActivityControl.WebAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HoursUsed, HoursUsedDto>().ReverseMap();
            CreateMap<Activity, ActivityDto>().ReverseMap();
            CreateMap<LoginDto, User>().ReverseMap();
        }
    }
}
