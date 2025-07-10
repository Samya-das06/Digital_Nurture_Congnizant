using CreateMigrations.Application.Parameters;

namespace CreateMigrations.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
