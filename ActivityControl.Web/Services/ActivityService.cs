using ActivityControl.Domain.Dto.Dto;
using ActivityControl.Web.Services.Interface;

namespace ActivityControl.Web.Services;

public class ActivityService : BaseService, IActivityService
{
    public ActivityService(IConfiguration configuration) : base(configuration) {}

    public Task<IEnumerable<ActivityDto>> GetActivities()
    {
        throw new NotImplementedException();
    }
}
