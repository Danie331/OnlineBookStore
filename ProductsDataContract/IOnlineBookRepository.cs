
using DomainEntities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataRepository.DataContract.ProductsDataContract
{
    public interface IOnlineBookRepository
    {
        Task AddAsync(Book book);
        Task<IEnumerable<Book>> AllAsync();
    }
}
