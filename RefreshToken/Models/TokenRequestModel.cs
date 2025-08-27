using System.ComponentModel.DataAnnotations;

namespace RefreshToken.Models
{
    public class TokenRequestModel
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}