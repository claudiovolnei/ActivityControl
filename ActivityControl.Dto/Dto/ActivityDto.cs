using ActivityControl.Domain.Models;
using System.ComponentModel.DataAnnotations;
using static ActivityControl.Domain.Models.Activity;

namespace ActivityControl.Domain.Dto.Dto;

public class ActivityDto
{
    public int? Id { get; set; }
    [Required(ErrorMessage = "Descrição obrigatória")]
    public string Description { get; set; } = String.Empty;
    [Required(ErrorMessage = "Observação obrigatória")]
    public string Observations { get; set; } = String.Empty;
    public ActivityStatus Status { get; set; }
}
