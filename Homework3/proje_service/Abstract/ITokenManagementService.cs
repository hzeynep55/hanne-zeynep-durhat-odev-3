using IdentityModel.Client;
using proje_base.Responce;
using System;
using System.Threading.Tasks;

namespace proje_service.Abstract
{
    public interface ITokenManagementService
    {
        Task<BaseResponse<TokenResponse>> GenerateTokensAsync(TokenRequest loginResource, DateTime now, string userAgent);
        Task GenerateTokensAsync(proje_base.Request.TokenRequest tokenRequest, DateTime utcNow, string userAgent);
    }
}
