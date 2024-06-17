using AutoMapper;
using MASProject.Server.Models.TransportModels;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Mappings
{
    public class TransportBookingProfile : Profile
    {
        public TransportBookingProfile()
        {
            CreateMap<TransportBooking, TransportBookingDTO>()
                .ReverseMap();
        }
    }
}
