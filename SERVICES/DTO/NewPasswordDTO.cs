using System.ComponentModel.DataAnnotations;
namespace SERVICES.DTO
{
    public class NewPasswordDTO
    {
        //automaticly validate min/max length and if the password are the same.
        [StringLength(maximumLength: 50, MinimumLength = 12, ErrorMessage = "The property {0} should have {1} maximum characters and {2} minimum characters")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The fields Password and PasswordConfirmation should be equals")]
        public string PasswordConfirmation { get; set; }

    }
}
 