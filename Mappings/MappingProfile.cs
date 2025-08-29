using AutoMapper;
using BlazorApp1.Dtos;
using BlazorApp1.Models;

namespace BlazorApp1.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MattersModel, MatterDto>().ReverseMap();

            CreateMap<EvidenceModel, EvidenceDto>()
                .ForMember(dest => dest.MatterName, opt => opt.MapFrom(src => src.Matter.MatterName))
                .ReverseMap();
        }
    }
}
