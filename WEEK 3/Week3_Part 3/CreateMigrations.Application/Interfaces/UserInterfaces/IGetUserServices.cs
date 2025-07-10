using System.Threading.Tasks;
using CreateMigrations.Application.DTOs.Account.Requests;
using CreateMigrations.Application.DTOs.Account.Responses;
using CreateMigrations.Application.Wrappers;

namespace CreateMigrations.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
