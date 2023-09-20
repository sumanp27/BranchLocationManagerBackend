using AutoMapper;
using WebAppAPI.Data;
using WebAppAPI.Models.Users;

namespace WebAppAPI.configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<ApiUserDto,ApiUser>().ReverseMap();
        }
    }
}
