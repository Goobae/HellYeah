namespace HY.Common.ReturnValues
{
    public class ErrorReturn : HYReturn
    {
        public ErrorReturn(string message) : base(false, message)
        {
        }
    }
}
