namespace BusTicketsMonolitic.Web.Data.Exceptions
{
    public class AsientoDbException : Exception
    {
        public AsientoDbException(string message) : base(message)
        {
        }

        public AsientoDbException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
