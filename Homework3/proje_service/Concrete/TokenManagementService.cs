using AutoMapper;
using IdentityModel.Client;
using Microsoft.Extensions.Options;
using proje_base.JwtConfig;
using proje_base.Responce;
using proje_data.Repository.Abstract;
using proje_data.UnitOfWork;
using proje_service.Abstract;
using System;
using System.Text;
using System.Threading.Tasks;

namespace proje_service.Concrete
{
    public class TokenManagementService : ITokenManagementService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly byte[] _secret;
        private readonly JwtConfig _jwtConfig;

        public TokenManagementService(IAccountRepository accountRepository, IMapper mapper, IUnitOfWork unitOfWork, IOptionsMonitor<JwtConfig> jwtConfig) : base()
        {
            this._accountRepository = accountRepository;
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
            this._jwtConfig = jwtConfig.CurrentValue;
            this._secret = Encoding.ASCII.GetBytes(_jwtConfig.Secret);
        }
        public Task<BaseResponse<TokenResponse>> GenerateTokensAsync(TokenRequest loginResource, DateTime now, string userAgent)
        {
            throw new NotImplementedException();
        }
    }
}
