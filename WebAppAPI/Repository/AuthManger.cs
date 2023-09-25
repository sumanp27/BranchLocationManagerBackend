using AutoMapper;
using Microsoft.AspNetCore.Identity;
using WebAppAPI.Contracts;
using WebAppAPI.Data;
using WebAppAPI.Models.Users;

namespace WebAppAPI.Repository
{
    public class AuthManager : IAuthManager
    {
        private ApiUser _user;

        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthManager> _logger;

        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager, IConfiguration configuration, ILogger<AuthManager> logger)
        {
            this._mapper = mapper;
            this._userManager = userManager;
            this._configuration = configuration;
            this._logger = logger;
        }
        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            _user = _mapper.Map<ApiUser>(userDto);
            _user.UserName = userDto.Email;

            var result = await _userManager.CreateAsync(_user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(_user, "User");
            }
            return result.Errors;
        }

        public async Task<AuthResponseDto> Login(LoginDto loginDto)
        {

            _logger.LogInformation($"Looking for an email{loginDto.Email}");

            _user = await _userManager.FindByEmailAsync(loginDto.Email);
            bool isValidUser = await _userManager.CheckPasswordAsync(_user, loginDto.Password);

            if (_user == null || isValidUser == false)
            {
                _logger.LogWarning($"Looking for user with  email{loginDto.Email} was not found");
                return null;
            }
            
            _logger.LogInformation($"token generated  for user with  email{loginDto.Email}  ");
            return new AuthResponseDto
            {
              
                UserId = _user.Id,
               
            };

        }

      

       
    }
}