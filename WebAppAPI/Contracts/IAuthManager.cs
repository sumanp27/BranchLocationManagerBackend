using Microsoft.AspNetCore.Identity;
using WebAppAPI.Models.Users;

namespace WebAppAPI.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);

        //Task <bool>Logout(LoginDto logoutDto);
    }
}