using AutoMapper;
using MASProject.Server.Models.TourModels;
using MASProject.Shared.DTOs.TourDTOs;

namespace MASProject.Server.Mappings
{
    /// <summary>
    /// AutoMapper profile for tour mappings.
    /// </summary>
    public class TourProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TourProfile"/> class.
        /// </summary>
        public TourProfile()
        {
            CreateMap<Tour, GetTourDTO>()
                .ForMember(dto => dto.HeaderPhotoURL, opt => opt.MapFrom(model => model.ImagesURL.FirstOrDefault() ?? string.Empty));

            CreateMap<Tour, UpdateTourDTO>()
                .ReverseMap();
        }
    }
}
