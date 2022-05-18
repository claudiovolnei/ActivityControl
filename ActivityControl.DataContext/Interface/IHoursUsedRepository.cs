using ActivityControl.Domain.Models;

namespace ActivityControl.DataContext.Interface;

public interface IHoursUsedRepository
{
    Task<IEnumerable<HoursUsed>> GetActivitysHourUsed(int idActivity);
    Task<HoursUsed> Create(HoursUsed hoursUsed);
    Task<HoursUsed> Update(HoursUsed hoursUsed);
}
