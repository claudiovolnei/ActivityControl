using ActivityControl.Application.Interfaces;
using ActivityControl.Domain.Class;
using ActivityControl.Domain.Dto.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ActivityControl.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<ActivityDto>>> Get()
        {
            var activityDtos = await _activityService.GetActivitys();

            if (activityDtos == null)
                return NotFound(new Response { Success = false, Message = "Não possui atividades!"});

            return Ok(new Response { Data = activityDtos });
        }

        [HttpGet("{id:int}", Name = "GetAtividade")]
        [Authorize]
        public async Task<ActionResult<ActivityDto>> GetAtiividade(int id)
        {
            var activityDto = await _activityService.GetActivityById(id);

            if (activityDto == null)
                return NotFound(new Response { Success = false, Message = "Atividade não encontrada!" });

            return Ok(new Response { Data = activityDto });
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Post([FromBody] ActivityDto activityDto)
        {
            if(activityDto == null)
                return BadRequest(new Response { Success = false, Message = "Atividade não pode ser nula."});

            await _activityService.AddActivity(activityDto);

            return new CreatedAtRouteResult("GetAtividade", 
                                            new Response { Data = activityDto, Message = "Atividade criada com sucesso!"});
        }

        [HttpPut("{id:int}")]
        [Authorize]
        public async Task<ActionResult> Put(int id,[FromBody] ActivityDto activityDto)
        {
            var activity = _activityService.GetActivityById(id);
            if (activity == null)
                return BadRequest(new Response { Success = false, Message = "Atividade inválida" });

            if (activityDto == null)
                return BadRequest(new Response { Success = false, Message = "Atividade não pode ser nula." });

            await _activityService.UpdateActivity(activityDto);

            return Ok(new Response { Data = activityDto, Message = "Atividade atualizada com sucesso!"});
        }

        [HttpDelete("{id:int}")]
        [Authorize]
        public async Task<ActionResult> Delete(int id)
        {
            var activityDto = await _activityService.GetActivityById(id);

            if (activityDto == null)
                return NotFound(new Response { Success = false, Message = "Atividade não encontrada!" });

            await _activityService.RemoveActivity(id);

            return Ok(new Response { Data = activityDto, Message = "Atividade deletada com sucesso!" });
        }

    }
}
