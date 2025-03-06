using CQRSSample.Models;

namespace CQRSSample.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly List<User> _users = new List<User>();

        public async Task<User> GetByIdAsync(int id)
        {
            var a = await Task.FromResult(_users);
            return await Task.FromResult(_users.Find(user => user.Id == id));
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Task.FromResult(_users);
        }

        public async Task AddAsync(User entity)
        {
            _users.Add(entity);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(User user)
        {
            await UpdateAsync(user);
            
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            if (user != null)
            {
                _users.Remove(user);
            }
            await Task.CompletedTask;
        }
    }
}