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
                .Include<LodgingBooking, LodgingBookingDTO>()
                .ReverseMap();

            CreateMap<TransportBooking, TransportBookingDTO>()
                .ReverseMap()
                .ForPath(model => model.TransportId, opt => opt.MapFrom(dto => dto.Transport.Id))
                .ForPath(model => model.Transport, opt => opt.Ignore());
            
            CreateMap<LodgingBooking, LodgingBookingDTO>()
                .ForMember(dto => dto.CheckInDate, opt => opt.MapFrom(model => DateConverter.ConvertToDateTime(model.CheckInDate)))
                .ForMember(dto => dto.CheckOutDate, opt => opt.MapFrom(model => DateConverter.ConvertToDateTime(model.CheckOutDate)))
                .ReverseMap()
                .ForPath(model => model.LodgingId, opt => opt.MapFrom(dto => dto.Lodging.Id))
                .ForPath(model => model.Lodging, opt => opt.Ignore())
                .ForPath(model => model.CheckInDate, opt => opt.MapFrom(dto => DateConverter.ConvertToDateOnly(dto.CheckInDate)))
                .ForPath(model => model.CheckOutDate, opt => opt.MapFrom(dto => DateConverter.ConvertToDateOnly(dto.CheckOutDate)));
        }
    }
}
