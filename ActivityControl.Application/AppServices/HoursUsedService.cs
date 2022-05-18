using ActivityControl.Application.Interfaces;
using ActivityControl.DataContext.Interface;
using ActivityControl.Domain.Dto.Dto;
using ActivityControl.Domain.Models;
using AutoMapper;

namespace ActivityControl.Application.AppServices;

public class HoursUsedService : IHoursUsedService
{
    private readonly IHoursUsedRepository _hoursUsedRepository;
    private readonly IMapper _mapper;
    public HoursUsedService(IHoursUsedRepository hoursUsedRepository, IMapper mapper)
    {
        _hoursUsedRepository = hoursUsedRepository;
        _mapper = mapper;   
    }
    public async Task AddHoursUsed(HoursUsedDto hoursUsedDto)
    {
        var hoursUsed = _mapper.Map<HoursUsed>(hoursUsedDto);
        await _hoursUsedRepository.Create(hoursUsed);
    }

    public async Task<IEnumerable<HoursUsedDto>> GetActivityHourUsed(int idActivity)
    {
        var hoursUseds = await _hoursUsedRepository.GetActivitysHourUsed(idActivity);
        return _mapper.Map<IEnumerable<HoursUsedDto>>(hoursUseds);
    }

    public async Task UpdateHoursUsed(HoursUsedDto hoursUsedDto)
    {
        var hoursUsed = _mapper.Map<HoursUsed>(hoursUsedDto);
        await _hoursUsedRepository.Update(hoursUsed);
    }
}
