using MASProject.Shared.DTOs.TourDTOs;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Services.TourServices
{
    public interface ITourService
    {
        public Task DeleteTourAsync(int id);

        public Task<GetTourDTO?> GetTourAsync(int id);
        public Task<UpdateTourDTO> GetUpdateTourAsync(int id);
        public Task<List<GetTourDTO>> GetToursAsync(int pageNumber, int pageSize);
        public Task<int> GetToursCountAsync();
        public Task UpdateTourAsync(UpdateTourDTO tour);
    }
}
