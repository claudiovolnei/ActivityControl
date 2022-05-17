using ActivityControl.Domain.Models;
using ActivityControl.DataContext.Context;
using ActivityControl.DataContext.Interface;
using Microsoft.EntityFrameworkCore;

namespace ActivityControl.DataContext.Repositories;

public class HoursUsedRepository : IHoursUsedRepository
{
    private readonly ActivityControlContext _context;
    public HoursUsedRepository(ActivityControlContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<HoursUsed>> GetActivitysHourUsed(int idActivity)
    {
        return await _context.HoursUseds.Where(h => h.Activity.Id == idActivity).ToListAsync();
    }
    public async Task<HoursUsed> Create(HoursUsed hoursUsed)
    {
        _context.HoursUseds.Add(hoursUsed);
        await _context.SaveChangesAsync();
        return hoursUsed;

    }
}
