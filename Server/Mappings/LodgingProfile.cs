using AutoMapper;
using MASProject.Server.Models.LodgingModels;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Mappings
{
    public class LodgingProfile : Profile
    {
        public LodgingProfile()
        {
            CreateMap<Lodging, LodgingDTO>();
        }
    }
}
