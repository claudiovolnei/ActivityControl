using System.ComponentModel.DataAnnotations;

namespace ActivityControl.Domain.Dto.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Password é obrigatório!")]
        public string? Password { get; set; } 
        [Required(ErrorMessage = "Email é obrigatório!")]
        public string? EmailAddress { get; set; }
    }
}
