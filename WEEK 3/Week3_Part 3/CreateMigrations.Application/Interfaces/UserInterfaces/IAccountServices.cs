using System.Threading.Tasks;
using CreateMigrations.Application.DTOs.Account.Requests;
using CreateMigrations.Application.DTOs.Account.Responses;
using CreateMigrations.Application.Wrappers;

namespace CreateMigrations.Application.Interfaces.UserInterfaces
{
    public interface IAccountServices
    {
        Task<BaseResult<string>> RegisterGhostAccount();
        Task<BaseResult> ChangePassword(ChangePasswordRequest model);
        Task<BaseResult> ChangeUserName(ChangeUserNameRequest model);
        Task<BaseResult<AuthenticationResponse>> Authenticate(AuthenticationRequest request);
        Task<BaseResult<AuthenticationResponse>> AuthenticateByUserName(string username);

    }
}
