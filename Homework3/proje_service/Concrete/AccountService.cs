using AutoMapper;
using proje_base.Exception;
using proje_base.Request;
using proje_base.Responce;
using proje_data.Model;
using proje_data.Repository.Abstract;
using proje_data.UnitOfWork;
using proje_dto.Dto;
using proje_service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_service.Concrete
{
    public class AccountService : BaseService<AccountDto, Account>, IAccountService
    {
        private readonly IAccountRepository accountRepository;
        
        public AccountService(IAccountRepository accountRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(accountRepository, mapper, unitOfWork)
        {
            this.accountRepository = accountRepository;
        }
        public override async Task<BaseResponse<AccountDto>> InsertAsync(AccountDto createAccountResource)
        {
            try
            {
                // Mapping Resource to Account
                var tempAccount = Mapper.Map<AccountDto, Account>(createAccountResource);

                await accountRepository.InsertAsync(tempAccount);
                await UnitOfWork.CompleteAsync();

                return new BaseResponse<AccountDto>(Mapper.Map<Account, AccountDto>(tempAccount));
            }
            catch (Exception ex)
            {
                throw new MessageResultException("Account_Saving_Error", ex);
            }
        }
        public Task<BaseResponse<AccountDto>> SelfUpdateAsync(int id, AccountDto resource)
        {
            throw new NotImplementedException();
        }
        public Task<BaseResponse<AccountDto>> UpdatePasswordAsync(int id, UpdatePasswordRequest resource)
        {
            throw new NotImplementedException();
        }
    }
}
