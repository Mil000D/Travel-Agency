using MASProject.Server.DAL.Context;
using MASProject.Server.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace MASProject.Server.DAL.UserRepositories
{
    /// <summary>
    /// Repository class for customer operations.
    /// </summary>
    public class CustomerRepository : IUserRepository<Customer>
    {
        private readonly MainDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public CustomerRepository(MainDbContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task AddUserAsync(Customer user)
        {
            _context.Customers.Add(user);
            await _context.SaveChangesAsync();
        }

        /// <inheritdoc />
        public async Task DeleteUserAsync(int id)
        {
            var user = await GetUserAsync(id);
            if (user != null)
            {
                _context.Customers.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        /// <inheritdoc />
        public async Task<Customer?> GetUserAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        /// <inheritdoc />
        public async Task<List<Customer>> GetUsersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        /// <inheritdoc />
        public async Task UpdateUserAsync(Customer user)
        {
            _context.Customers.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
