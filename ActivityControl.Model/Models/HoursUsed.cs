namespace ActivityControl.Domain.Models;

public class HoursUsed
{
    public int Id { get; set; }    
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public Activity Activity { get; set; } 

}
