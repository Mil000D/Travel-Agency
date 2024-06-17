using MASProject.Server.DAL.Context;
using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.UserRepositories
{
    public class AdminRepository : IUserRepository<Admin>
    {
        private readonly MainDbContext _context;
        public AdminRepository(MainDbContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(Admin user)
        {
            _context.Admins.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await GetUserAsync(id);
            if (user != null)
            {
                _context.Admins.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Admin?> GetUserAsync(int id)
        {
            return await _context.Admins.FindAsync(id);
        }

        public async Task<List<Admin>> GetUsersAsync()
        {
            return await _context.Admins.ToListAsync();
        }

        public async Task UpdateUserAsync(Admin user)
        {
            _context.Admins.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
