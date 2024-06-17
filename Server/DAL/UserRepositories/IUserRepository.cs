using MASProject.Server.Models.UserModels;

namespace MASProject.Server.DAL.UserRepositories
{
    public interface IUserRepository<T> where T : User
    {
        public Task AddUserAsync(T user);
        public Task DeleteUserAsync(int id);
        public Task<T?> GetUserAsync(int id);
        public Task<List<T>> GetUsersAsync();
        public Task UpdateUserAsync(T user);
    }
}
