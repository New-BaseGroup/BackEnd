using System.ComponentModel.DataAnnotations;
namespace SERVICES.DTO
{
    public record RegisterUserDTO
    {

        [Required(ErrorMessage = "{0} is a mandatory field")]
        public string User { get; set; }


        [Required(ErrorMessage = "{0} is a mandatory field")] 
        public string Password { get; init; }

        [Required(ErrorMessage = "{0} is a mandatory field")]
        public string Email { get; init; }

    }
}
 