using Restarunt.common.DTOs.Account;

namespace Restarunt.common.DTOs.service
{
    public interface IAccountService
    {
        Task<LoginResponse> verifylogindetails(LoginRequest request);
    }
}