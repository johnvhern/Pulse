using Pulse.Model;

namespace Pulse.Repository.UserRepo
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task Add(User user);
        Task Update(User user);
        Task Delete(User user);
    }
}