using MASProject.Server.DAL.Context;
using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.UserRepositories
{
    public class CustomerRepository : IUserRepository<Customer>
    {
        private readonly MainDbContext _context;
        public CustomerRepository(MainDbContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(Customer user)
        {
            _context.Customers.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await GetUserAsync(id);
            if (user != null)
            {
                _context.Customers.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Customer?> GetUserAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<List<Customer>> GetUsersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task UpdateUserAsync(Customer user)
        {
            _context.Customers.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
