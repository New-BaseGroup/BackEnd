using System.ComponentModel.DataAnnotations;
namespace API.DTO
{
    public record LoginDTO
    {

        [Required(ErrorMessage = "{0} is a mandatory field")]
        public string user { get; set; }


        [Required(ErrorMessage = "{0} is a mandatory field")] 
        public string password { get; init; }

    }
}
 