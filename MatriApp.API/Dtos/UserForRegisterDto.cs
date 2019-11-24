using System.ComponentModel.DataAnnotations;

namespace MatriApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4,ErrorMessage = "You must specify minimum 4 char and maximum 8 char")]
        public string Password { get; set; }
    }
}