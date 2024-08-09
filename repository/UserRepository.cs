using CmsBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace CmsBackend.repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Set<User>().ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Set<User>().FindAsync(id);
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Set<User>().AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Set<User>().Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Set<User>().FindAsync(id);
            if (user != null)
            {
                _context.Set<User>().Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
