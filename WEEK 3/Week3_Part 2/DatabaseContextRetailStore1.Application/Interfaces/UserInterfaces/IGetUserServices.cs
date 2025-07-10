using System.Threading.Tasks;
using DatabaseContextRetailStore1.Application.DTOs.Account.Requests;
using DatabaseContextRetailStore1.Application.DTOs.Account.Responses;
using DatabaseContextRetailStore1.Application.Wrappers;

namespace DatabaseContextRetailStore1.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
