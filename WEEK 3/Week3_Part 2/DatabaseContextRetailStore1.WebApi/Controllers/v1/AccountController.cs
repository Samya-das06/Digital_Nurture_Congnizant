using System.Threading.Tasks;
using Asp.Versioning;
using DatabaseContextRetailStore1.Application.DTOs.Account.Requests;
using DatabaseContextRetailStore1.Application.DTOs.Account.Responses;
using DatabaseContextRetailStore1.Application.Interfaces.UserInterfaces;
using DatabaseContextRetailStore1.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseContextRetailStore1.WebApi.Controllers.v1
{
    [ApiVersion("1")]
    public class AccountController(IAccountServices accountServices) : BaseApiController
    {
        [HttpPost]
        public async Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request)
            => await accountServices.Authenticate(request);

        [HttpPut, Authorize]
        public async Task<BaseResult> ChangeUserName(ChangeUserNameRequest model)
            => await accountServices.ChangeUserName(model);

        [HttpPut, Authorize]
        public async Task<BaseResult> ChangePassword(ChangePasswordRequest model)
            => await accountServices.ChangePassword(model);

        [HttpPost]
        public async Task<BaseResult<AuthenticationResponse>> Start()
        {
            var ghostUsername = await accountServices.RegisterGhostAccount();
            return await accountServices.AuthenticateByUserName(ghostUsername.Data);
        }
    }
}
