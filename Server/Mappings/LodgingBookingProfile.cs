using AutoMapper;
using MASProject.Server.Models.LodgingModels;
using MASProject.Shared.DTOs.UseCaseDTOs;
using MASProject.Shared.SharedConverters;

namespace MASProject.Server.Mappings
{
    public class LodgingBookingProfile : Profile
    {
        public LodgingBookingProfile()
        {
            CreateMap<LodgingBooking, LodgingBookingDTO>()
                .ForMember(dest => dest.CheckInDate, opt => opt.MapFrom(src => DateConverter.ConvertToDateTime(src.CheckInDate)))
                .ForMember(dest => dest.CheckOutDate, opt => opt.MapFrom(src => DateConverter.ConvertToDateTime(src.CheckOutDate)))
                .ReverseMap();
        }
    }
}
