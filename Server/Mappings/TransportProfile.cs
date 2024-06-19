using AutoMapper;
using MASProject.Server.Models.TransportModels;
using MASProject.Shared.DTOs.TransportDTOs;

namespace MASProject.Server.Mappings
{
    /// <summary>
    /// AutoMapper profile for transport mappings.
    /// </summary>
    public class TransportProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportProfile"/> class.
        /// </summary>
        public TransportProfile()
        {
            CreateMap<Transport, TransportDTO>()
                .ForMember(dto => dto.Name, opt => opt.MapFrom(model => model.ToString()));
        }
    }
}
