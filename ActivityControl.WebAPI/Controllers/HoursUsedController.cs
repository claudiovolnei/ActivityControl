using ActivityControl.Domain.Class;
using ActivityControl.Domain.Dto.Dto;
using ActivityControl.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ActivityControl.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HoursUsedController : ControllerBase
{
    private readonly IHoursUsedService _hoursUsedService; 
    public HoursUsedController(IHoursUsedService hoursUsedService)
    {
        _hoursUsedService = hoursUsedService;
    }

    [HttpGet("{idActivity:int}", Name = "GetHoursUsedActivity")]
    [Authorize]
    public async Task<ActionResult<IEnumerable<HoursUsedDto>>> Get(int idActivity)
    {
        var hoursUsedsDto = await _hoursUsedService.GetActivityHourUsed(idActivity);

        if (hoursUsedsDto == null)
            return NotFound(new Response { Success = false ,Message = "Horas utilizadas não encontrada" });

        return Ok( new Response { Data = hoursUsedsDto });
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult> Post([FromBody] HoursUsedDto hoursUsedDto)
    {

        if (hoursUsedDto == null)
            return BadRequest(new Response { Success = false, Message = "Horas utilizadas não pode ser nula." });

        await _hoursUsedService.AddHoursUsed(hoursUsedDto);

        return new CreatedAtRouteResult("GetHoursUsedActivity" ,new Response { Data = hoursUsedDto, Message = "Horas utilizada criada com sucesso!" });
    }
}
