using MASProject.Server.Models.TourModels;

namespace MASProject.Server.DAL.TourRepositories
{
    public interface ITourRepository
    {
        public Task AddTourAsync(Tour tour);
        public Task DeleteTourAsync(int id);
        public Task<Tour?> GetTourAsync(int id);
        public Task<(List<Tour>, int)> GetToursAndToursCountAsync(int pageNumber, int pageSize, string? search = null, DateTime? startDate = null, DateTime? endDate = null);
        public Task<int> GetToursCountAsync();
        public Task UpdateTourAsync(Tour tour);
    }
}
