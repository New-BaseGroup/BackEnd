using System.ComponentModel.DataAnnotations;
namespace SERVICES.DTO
{
    public record LoginDTO
    {

        [Required(ErrorMessage = "{0} is a mandatory field")]
        public string User { get; set; }


        [Required(ErrorMessage = "{0} is a mandatory field")] 
        public string Password { get; init; }

    }
}
 