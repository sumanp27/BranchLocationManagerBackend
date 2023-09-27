using Microsoft.AspNetCore.Identity;
using WebAppAPI.Models.Users;

namespace WebAppAPI.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<IdentityError> Login(LoginDto loginDto);

        
    }
}