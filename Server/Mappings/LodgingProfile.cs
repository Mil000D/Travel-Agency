using AutoMapper;
using MASProject.Server.Models.LodgingModels;
using MASProject.Shared.DTOs.LodgingDTOs;

namespace MASProject.Server.Mappings
{
    /// <summary>
    /// AutoMapper profile for lodging mappings.
    /// </summary>
    public class LodgingProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingProfile"/> class.
        /// </summary>
        public LodgingProfile()
        {
            CreateMap<Lodging, LodgingDTO>();
        }
    }
}
