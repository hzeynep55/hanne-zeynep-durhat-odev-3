using IdentityModel.Client;
using Microsoft.EntityFrameworkCore;
using proje_data.Context;
using proje_data.Model;
using proje_data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Repository.Concrete
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(AppDbContext context) : base(context) { }

        public async Task<Account> GetByIdAsync(int id, bool hasToken)
        {
            var queryable = Context.Account.Where(x => x.Id.Equals(id));
            return await queryable.SingleOrDefaultAsync();
        }

        public async Task<int> TotalRecordAsync() => await Context.Account.CountAsync();

       

        public async Task<Account> ValidateCredentialsAsync(TokenRequest loginResource)
        {
            var accountStored = await Context.Account
                .Where(x => x.UserName == loginResource.UserName.ToLower())
                .SingleOrDefaultAsync();
        }
    }
}
