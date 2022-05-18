namespace ActivityControl.Web.Services;

public abstract class BaseService
{
    public readonly IConfiguration _configuration;

    public BaseService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
}
