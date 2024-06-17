using MASProject.Server.Models.TransportModels;

namespace MASProject.Server.DAL.TransportRepositories
{
    public interface ITransportRepository<T> where T : Transport
    {
        public Task AddTransportAsync(T transport);
        public Task DeleteTransportAsync(int id);
        public Task<T?> GetTransportAsync(int id);
        public Task<List<T>> GetTransportsAsync();
        public Task UpdateTransportAsync(T transport);
    }
}
