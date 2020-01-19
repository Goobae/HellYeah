using HY.Common.ReturnValues;
using System;

namespace HY.Data.Logger
{
    public interface ILogger
    {
        HYReturn LogWarning(string message);
        HYReturn LogInformation(string message);
        HYReturn LogMessage(string message);
        HYReturn LogError(string message);
        HYReturn LogError(Exception message);
    }
}
