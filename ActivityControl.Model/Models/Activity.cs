using System.ComponentModel.DataAnnotations;

namespace ActivityControl.Domain.Models;

public class Activity
{
    public int Id { get; set; }
    public string Description { get; set; } = String.Empty;
    public string Observations { get; set; } = String.Empty ;
    public ActivityStatus Status { get; set; }
    public List<HoursUsed>? HoursUseds { get; set; } = null;

    public enum ActivityStatus
    {
        [Display(Name = "Não Iniciada")]
        NaoIniciada = 0,
        [Display(Name = "Iniciada")]
        Iniciada = 1,
        [Display(Name = "Trabalhando")]
        Trabalhando = 2,
        [Display(Name = "Finalizada")]
        Finalizada = 3,
        [Display(Name = "Cancelada")]
        Cancelada = 4
    }


}
