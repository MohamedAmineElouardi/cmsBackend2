using CmsBackend.Model;
using CmsBackend.repository;

namespace CmsBackend.services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return _userRepository.GetAllUsersAsync();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            return _userRepository.GetUserByIdAsync(id);
        }

        public Task AddUserAsync(User user)
        {
            return _userRepository.AddUserAsync(user);
        }

        public Task UpdateUserAsync(User user)
        {
            return _userRepository.UpdateUserAsync(user);
        }

        public Task DeleteUserAsync(int id)
        {
            return _userRepository.DeleteUserAsync(id);
        }
    }
}
