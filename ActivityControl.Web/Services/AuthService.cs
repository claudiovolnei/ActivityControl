using ActivityControl.Domain.Dto.Dto;
using ActivityControl.Web.Services.Interface;
using Newtonsoft.Json;
using System.Text;

namespace ActivityControl.Web.Services
{
    public class AuthService : BaseService
    {
        private readonly HttpClient _http;
        public AuthService(IConfiguration configuration, HttpClient http) : base(configuration) 
        {
            _http = http;
        }
        public Task<CreateUserDto> CreateUser(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto> Login(LoginDto loginDto)
        {
            var configuration = $"{base._configuration.GetValue<string>("Backend")}api/authenticate/login";
            string json = JsonConvert.SerializeObject(loginDto);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _http.PostAsync(configuration, content);

            return JsonConvert.DeserializeObject<ResponseDto>(response.Content.ReadAsStringAsync().Result);
        }


    }
}
