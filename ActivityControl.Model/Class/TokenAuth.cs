namespace ActivityControl.Domain.Class;

public class TokenAuth
{
    public string? Token { get; set; }
    public DateTime ValidTo { get; set; }
}
