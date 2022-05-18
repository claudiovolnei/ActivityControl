using System.ComponentModel.DataAnnotations;

namespace ActivityControl.Domain.Dto.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage = "User Name é obrigatório!")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password é obrigatório!")]
        public string? Password { get; set; }
    }
}
