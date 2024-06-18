using AutoMapper;
using MASProject.Server.Models.LodgingModels;
using MASProject.Server.Models.SharedModels;
using MASProject.Server.Models.TransportModels;
using MASProject.Shared.DTOs.UseCaseDTOs;
using MASProject.Shared.SharedConverters;

namespace MASProject.Server.Mappings
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, BookingDTO>()
                .Include<TransportBooking, TransportBookingDTO>()
                .Include<LodgingBooking, LodgingBookingDTO>();

            CreateMap<TransportBooking, TransportBookingDTO>();
            CreateMap<LodgingBooking, LodgingBookingDTO>()
                .ForMember(dest => dest.CheckInDate, opt => opt.MapFrom(src => DateConverter.ConvertToDateTime(src.CheckInDate)))
                .ForMember(dest => dest.CheckOutDate, opt => opt.MapFrom(src => DateConverter.ConvertToDateTime(src.CheckOutDate)))
                .ReverseMap();
        }
    }
}
