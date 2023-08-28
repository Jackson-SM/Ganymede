using Ganymede.Entities;

namespace Ganymede.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> Register(User user);
        public Task<User> GetUserById(Guid id);
        public Task<User?> GetUserByEmail(string email);
    }
}
