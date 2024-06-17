using AutoMapper;
using MASProject.Server.Models.TourModels;
using MASProject.Shared.DTOs.TourDTOs;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Mappings
{
    public class TourProfile : Profile
    {
        public TourProfile()
        {
            CreateMap<Tour, GetTourDTO>()
                .ForMember(dest => dest.HeaderPhotoURL, opt => opt.MapFrom(src => src.ImagesURL.FirstOrDefault() ?? string.Empty));
        }
    }
}
