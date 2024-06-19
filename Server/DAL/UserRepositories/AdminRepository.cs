using MASProject.Server.DAL.Context;
using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.UserRepositories
{
    /// <summary>
    /// Repository class for admin operations.
    /// </summary>
    public class AdminRepository : IUserRepository<Admin>
    {
        private readonly MainDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public AdminRepository(MainDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task AddUserAsync(Admin user)
        {
            _context.Admins.Add(user);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task DeleteUserAsync(int id)
        {
            var user = await GetUserAsync(id);
            if (user != null)
            {
                _context.Admins.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        /// <inheritdoc />
        public async Task<Admin?> GetUserAsync(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<List<Admin>> GetUsersAsync()
        {
            return await _context.Admins.ToListAsync();
        }

        /// <inheritdoc />
        public async Task UpdateUserAsync(Admin user)
        {
            _context.Admins.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
