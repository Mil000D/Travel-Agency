using MASProject.Server.Models.TourModels;
using MASProject.Shared.DTOs.TourDTOs;
using MASProject.Shared.DTOs.UseCaseDTOs;

namespace MASProject.Server.Services.TourServices
{
    public interface ITourService
    {
        public Task DeleteTourAsync(int id);

        public Task<GetTourDTO?> GetTourDTOAsync(int id);
        public Task<UpdateTourDTO> GetUpdateTourDTOAsync(int id);
        public Task<GetAllToursDTO> GetTourDTOsAndToursCountAsync(int pageNumber, int pageSize, string? search = null, string? startDate = null, string? endDate = null);
        public Task<int> GetToursCountAsync();
        public Task UpdateTourAsync(UpdateTourDTO tour);
    }
}
