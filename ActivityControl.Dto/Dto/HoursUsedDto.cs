using ActivityControl.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace ActivityControl.Domain.Dto.Dto;

public class HoursUsedDto
{
    public int? Id { get; set; }
    [Required(ErrorMessage = "Inicio obrigatório")]
    public DateTime Start { get; set; }
    [Required(ErrorMessage = "Fim obrigatório")]
    public DateTime End { get; set; }
    public Activity? Activity { get; set; }
}
