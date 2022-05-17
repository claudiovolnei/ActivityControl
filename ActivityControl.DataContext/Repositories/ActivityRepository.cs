using ActivityControl.Domain.Models;
using ActivityControl.DataContext.Context;
using ActivityControl.DataContext.Interface;
using Microsoft.EntityFrameworkCore;

namespace ActivityControl.DataContext.Repositories;

public class ActivityRepository : IActivityRepository
{
    private readonly ActivityControlContext _context;
    public ActivityRepository(ActivityControlContext context)
    {
        _context = context;
    }
    public async Task<Activity> GetById(int id)
    {
        return await _context.Activitys.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<Activity>> GetAll()
    {
        return await _context.Activitys.ToListAsync();
    }
    public async Task<Activity> Create(Activity activity)
    {
        _context.Activitys.Add(activity);
        await _context.SaveChangesAsync();
        return activity;
    }
    public async Task<Activity> Update(Activity activity)
    {
        _context.Attach(activity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return activity;
    }
    public async Task<Activity> Delete(int id)
    {
        var activity = await GetById(id);
        _context.Activitys.Remove(activity);
        await _context.SaveChangesAsync();
        return activity;
    }
}
