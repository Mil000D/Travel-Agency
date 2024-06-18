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
                .ForMember(dto => dto.HeaderPhotoURL, opt => opt.MapFrom(model => model.ImagesURL.FirstOrDefault() ?? string.Empty));

            CreateMap<Tour, UpdateTourDTO>()
                .ReverseMap();
        }
    }
}
