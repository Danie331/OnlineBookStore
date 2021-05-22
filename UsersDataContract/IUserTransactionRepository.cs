
using System.Threading.Tasks;

namespace DataRepository.DataContract.UsersDataContract
{
    public interface IUserTransactionRepository
    {
        Task SubscribeToBookAsync(int bookId, int userId);
        Task UnsubscribeFromBookAsync(int bookId, int userId);
    }
}
