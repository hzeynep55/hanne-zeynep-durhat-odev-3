using IdentityModel.Client;
using proje_data.Model;
using System.Threading.Tasks;

namespace proje_data.Repository.Abstract
{
    public interface IAccountRepository:IGenericRepository<Account>
    {
        Task<int> TotalRecordAsync();
        Task<Account> ValidateCredentialsAsync(TokenRequest loginResource);
        Task<Account> GetByIdAsync(int id, bool hasToken);
    }
}
