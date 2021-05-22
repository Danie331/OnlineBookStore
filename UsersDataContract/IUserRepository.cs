
using DomainEntities.Models;
using System.Threading.Tasks;

namespace DataRepository.DataContract.UsersDataContract
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> FindAsync(string emailAddress, string password);
    }
}
