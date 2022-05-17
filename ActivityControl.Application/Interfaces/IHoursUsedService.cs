using ActivityControl.Domain.Dto.Dto;

namespace ActivityControl.Application.Interfaces;
public interface IHoursUsedService
{
    Task<IEnumerable<HoursUsedDto>> GetActivityHourUsed(int idActivity);
    Task AddHoursUsed(HoursUsedDto hoursUsedDto);
}
