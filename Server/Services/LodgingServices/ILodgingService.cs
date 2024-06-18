using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Services.LodgingServices
{
    public interface ILodgingService
    {
        public Task<List<LodgingDTO>> GetLodgingDTOsAsync();
    }
}
