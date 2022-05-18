using ActivityControl.Domain.Dto.Dto;

namespace ActivityControl.Web.Services.Interface
{
    public interface IAuthService
    {
        Task<string> Login(LoginDto loginDto);
        Task<CreateUserDto> CreateUser(CreateUserDto createUser);
    }
}
