using AutoMapper;
using MASProject.Server.Models.TransportModels;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Mappings
{
    public class TransportProfile : Profile
    {
        public TransportProfile()
        {
            CreateMap<Transport, TransportDTO>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.TransportType.ToString()))
                .ReverseMap();
        }
    }
}
