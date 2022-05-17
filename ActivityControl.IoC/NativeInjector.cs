using ActivityControl.Application.AppServices;
using ActivityControl.Application.Interfaces;
using ActivityControl.DataContext.Interface;
using ActivityControl.DataContext.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ActivityControl.IoC;

public class NativeInjector
{
    public static void RegisterServices(IServiceCollection services)
    {
        //AppServices   
        services.AddScoped<IHoursUsedService, HoursUsedService>();
        services.AddScoped<IActivityService, ActivityService>();

        //Repositories
        services.AddScoped<IHoursUsedRepository, HoursUsedRepository>();
        services.AddScoped<IActivityRepository, ActivityRepository>();
    }
}
