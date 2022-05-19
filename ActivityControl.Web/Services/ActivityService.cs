using ActivityControl.Domain.Dto.Dto;
using Newtonsoft.Json;
using System.Text;

namespace ActivityControl.Web.Services;

public class ActivityService : BaseService
{
    private readonly HttpClient _http;
    public ActivityService(IConfiguration configuration, HttpClient http) : base(configuration) 
    {
        _http = http;
    }

    public async Task<ResponseDto> GetActivities(string? token)
    {
        var configuration = $"{base._configuration.GetValue<string>("Backend")}api/activity";
        var requestMsg = new HttpRequestMessage(HttpMethod.Get, configuration);
        requestMsg.Headers.Add("Authorization", "Bearer " + token);
        var response = await _http.SendAsync(requestMsg);

        return JsonConvert.DeserializeObject<ResponseDto>(response.Content.ReadAsStringAsync().Result);
    }
}
