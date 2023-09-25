using System.ComponentModel.DataAnnotations;

namespace WebAppAPI.Models.Users
{
    public class ApiUserDto:LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
