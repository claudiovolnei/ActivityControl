namespace ActivityControl.Domain.Class;

public class Response
{
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
    public object? Data { get; set; }
}
