using System.Threading.Tasks;
using DatabaseContextRetailStore1.Application.DTOs.Account.Requests;
using DatabaseContextRetailStore1.Application.DTOs.Account.Responses;
using DatabaseContextRetailStore1.Application.Wrappers;

namespace DatabaseContextRetailStore1.Application.Interfaces.UserInterfaces
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
