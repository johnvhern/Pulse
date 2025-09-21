using Microsoft.EntityFrameworkCore;
using Pulse.Data;
using Pulse.Model;

namespace Pulse.Repository.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly PulseDbContext _db;
        public UserRepository(PulseDbContext db)
        {
            _db = db;
        }
        public async Task Add(User user)
        {
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task Update(User user)
        {
            _db.Users.Update(user);
            await _db.SaveChangesAsync();
        }
    }
}