using ActivityControl.Application.Interfaces;
using ActivityControl.DataContext.Interface;
using ActivityControl.Domain.Dto.Dto;
using ActivityControl.Domain.Models;
using AutoMapper;

namespace ActivityControl.Application.AppServices;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _activityRepository;
    private readonly IMapper _mapper;
    public ActivityService(IActivityRepository activityRepository, IMapper mapper)
    {
        _activityRepository = activityRepository;
        _mapper = mapper;  
    }
    public async Task<IEnumerable<ActivityDto>> GetActivitys()
    {
        var activitys = await _activityRepository.GetAll();
        return _mapper.Map<IEnumerable<ActivityDto>>(activitys);
    }
    public async Task<ActivityDto> GetActivityById(int id)
    {
        var activity = await _activityRepository.GetById(id);
        return _mapper.Map<ActivityDto>(activity);
    }
    public async Task AddActivity(ActivityDto activityDto)
    {
        var activity = _mapper.Map<Activity>(activityDto);
        await _activityRepository.Create(activity);
        activityDto.Id = activity.Id;
    }
    public async Task UpdateActivity(ActivityDto activityDto)
    {
        var activity = await _activityRepository.GetById(activityDto.Id.Value);
        activity = _mapper.Map(activityDto, activity);
        await _activityRepository.Update(activity);
    }
    public async Task RemoveActivity(int id)
    {
        var activity = await _activityRepository.GetById(id);
        await _activityRepository.Delete(activity.Id);
    }

}
