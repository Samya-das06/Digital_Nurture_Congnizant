using DatabaseContextRetailStore1.Application.Parameters;

namespace DatabaseContextRetailStore1.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
