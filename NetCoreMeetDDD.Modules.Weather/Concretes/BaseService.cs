using Microsoft.Extensions.Logging;

namespace NetCoreMeetDDD.Modules.Weather.Concretes;

public abstract class BaseService
{
    protected ILogger Logger;

    protected BaseService(ILoggerFactory loggerFactory)
    {
        Logger = loggerFactory.CreateLogger(GetType());
    }
}