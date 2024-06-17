using MASProject.Server.Models.LodgingModels;

namespace MASProject.Server.DAL.LodgingRepositories
{
    public interface ILodgingRepository
    {
        public Task<Lodging?> GetLodgingAsync(int id);
        public Task<List<Lodging>> GetLodgingsAsync();
        public Task AddLodgingAsync(Lodging lodging);
        public Task UpdateLodgingAsync(Lodging lodging);
        public Task DeleteLodgingAsync(int id);
    }
}
