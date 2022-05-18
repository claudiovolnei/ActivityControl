namespace ActivityControl.Domain.Dto.Dto;

public class ResponseDto
{
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
    public object? Data { get; set; }
}
