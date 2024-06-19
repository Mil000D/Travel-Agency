using MASProject.Shared.DTOs.LodgingDTOs;

namespace MASProject.Server.Services.LodgingServices
{
    /// <summary>
    /// Interface for lodging services.
    /// </summary>
    public interface ILodgingService
    {
        /// <summary>
        /// Asynchronously retrieves a list of LodgingDTOs.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation, with a list of LodgingDTOs as the result.</returns>
        public Task<List<LodgingDTO>> GetLodgingDTOsAsync();
    }
}
