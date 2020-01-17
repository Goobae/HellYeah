namespace HY.Common.ReturnValues
{
    public abstract class HYReturn
    {
        public bool Failure { get { return !Success; } }
        public bool Success { get; private set; }
        public string ErrorMessage { get; private set; }

        public HYReturn(bool success, string message)
        {
            Success = success;
            ErrorMessage = message;
        }
    }
}
