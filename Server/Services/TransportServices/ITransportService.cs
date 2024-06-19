using MASProject.Shared.DTOs.TransportDTOs;

namespace MASProject.Server.Services.TransportServices
{
    /// <summary>
    /// Interface for transport services.
    /// </summary>
    public interface ITransportService
    {
        /// <summary>
        /// Asynchronously retrieves a list of TransportDTOs.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation,
        /// with a list of TransportDTOs as the result.</returns>
        public Task<List<TransportDTO>> GetTransportDTOsAsync();
    }
}
