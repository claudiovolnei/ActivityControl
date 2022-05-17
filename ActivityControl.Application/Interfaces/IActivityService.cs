using ActivityControl.Domain.Dto.Dto;

namespace ActivityControl.Application.Interfaces;

public interface IActivityService
{
    Task<IEnumerable<ActivityDto>> GetActivitys();
    Task<ActivityDto> GetActivityById(int id);
    Task AddActivity(ActivityDto activityDto);
    Task UpdateActivity(ActivityDto activityDto);
    Task RemoveActivity(int id);
}
