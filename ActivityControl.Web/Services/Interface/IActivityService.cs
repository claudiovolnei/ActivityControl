using ActivityControl.Domain.Dto.Dto;

namespace ActivityControl.Web.Services.Interface;

public interface IActivityService
{
    Task<IEnumerable<ActivityDto>> GetActivities();
}
