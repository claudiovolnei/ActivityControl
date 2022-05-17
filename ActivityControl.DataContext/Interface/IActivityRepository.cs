using ActivityControl.Domain.Models;

namespace ActivityControl.DataContext.Interface;

public interface IActivityRepository
{
    Task<IEnumerable<Activity>> GetAll();
    Task<Activity> GetById(int id);
    Task<Activity> Create(Activity activity);
    Task<Activity> Update(Activity activity);
    Task<Activity> Delete(int id);
}
