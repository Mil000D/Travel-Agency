using MASProject.Server.Models.TourModels;

namespace MASProject.Server.DAL.TourRepositories
{
    public interface ITourRepository
    {
        public Task AddTourAsync(Tour tour);
        public Task DeleteTourAsync(int id);
        public Task<Tour?> GetTourAsync(int id);
        public Task<List<Tour>> GetToursAsync(int pageNumber, int pageSize);
        public Task<int> GetToursCountAsync();
        public Task UpdateTourAsync(Tour tour);
    }
}
