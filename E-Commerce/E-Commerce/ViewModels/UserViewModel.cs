using System.ComponentModel.DataAnnotations;

namespace E_Commerce.ViewModels
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password Is Not Matched")]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }

    }
}
