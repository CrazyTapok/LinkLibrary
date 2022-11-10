using AutoMapper;
using Data.Entities;
using Logic.DTO;

namespace Logic.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Link, LinkDTO>().ReverseMap();
        }
    }
}