using HY.Common.ReturnValues;

namespace HY.Data.Logger
{
    public interface ILogger
    {
        HYReturn LogWarning(string message);
        HYReturn LogInformation(string message);
        HYReturn LogMessage(string message);
        HYReturn LogError(string message);
    }
}
