namespace BusTicketsMonolitic.Web.Data.Exceptions
{
    public class BusDbException : Exception
    {
        public BusDbException(string message) : base(message)
        {
        }

        public BusDbException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
