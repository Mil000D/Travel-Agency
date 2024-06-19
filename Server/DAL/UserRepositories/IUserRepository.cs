using MASProject.Server.Models.UserModels;

namespace MASProject.Server.DAL.UserRepositories
{
    /// <summary>
    /// Generic interface for user repository operations.
    /// </summary>
    /// <typeparam name="T">Type of user, must inherit from <see cref="User"/>.</typeparam>
    public interface IUserRepository<T> where T : User
    {
        /// <summary>
        /// Asynchronously adds a user.
        /// </summary>
        /// <param name="user">The user to add.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task AddUserAsync(T user);

        /// <summary>
        /// Asynchronously deletes a user by specified ID.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task DeleteUserAsync(int id);

        /// <summary>
        /// Asynchronously retrieves a user by specified ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>A Task representing the asynchronous operation, with the user as the result.</returns>
        public Task<T?> GetUserAsync(int id);

        /// <summary>
        /// Asynchronously retrieves all users.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation, with a list of users as the result.</returns>
        public Task<List<T>> GetUsersAsync();

        /// <summary>
        /// Asynchronously updates a user.
        /// </summary>
        /// <param name="user">The user to update.</param>
        /// <returns>A Task representing the asynchronous operation.</returns>
        public Task UpdateUserAsync(T user);
    }
}
