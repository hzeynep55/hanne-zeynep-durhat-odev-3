using proje_base.Request;
using proje_base.Responce;
using proje_data.Model;
using proje_dto.Dto;
using System.Threading.Tasks;

namespace proje_service.Abstract
{
    public interface IAccountService : IBaseService<AccountDto, Account>
    {
        Task<BaseResponse<AccountDto>> InsertAsync(AccountDto createAccountResource);
        Task<BaseResponse<AccountDto>> SelfUpdateAsync(int id, AccountDto resource);
        Task<BaseResponse<AccountDto>> UpdatePasswordAsync(int id, UpdatePasswordRequest resource);
    }
}
