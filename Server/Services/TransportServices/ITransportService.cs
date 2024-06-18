using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Services.TransportServices
{
    public interface ITransportService
    {
        public Task<List<TransportDTO>> GetTransportsAsync();
    }
}
