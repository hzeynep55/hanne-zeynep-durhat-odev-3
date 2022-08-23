using IdentityModel.Client;
using Microsoft.AspNetCore.Mvc;
using proje_service.Abstract;
using Serilog;
using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_api.Controller
{
    [ApiController]
    [Route("protein/v1/api/[controller]")]
    public class TokenController:ControllerBase
    {
        private readonly ITokenManagementService tokenManagementService;

        public TokenController(ITokenManagementService tokenManagementService) : base()
        {
            this.tokenManagementService = tokenManagementService;
        }


        [HttpPost]
        public async Task<IActionResult> LoginAsync([FromBody] TokenRequest tokenRequest)
        {
            string userAgent = Request.Headers["User-Agent"].ToString();
            var result = await tokenManagementService.GenerateTokensAsync(tokenRequest, DateTime.UtcNow, userAgent);

            /*if (result.Success)
            {
                Log.Information($"Role {result.Response.Role}: is loged in.");
                return Ok(result);
            }*/

            return Unauthorized(result);
        }
    }
}
