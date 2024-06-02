namespace BusTicketsMonolitic.Web.Data.Exceptions
{
    public class ClienteDbException : Exception
    {
        public ClienteDbException(string message) : base(message) { }

        public ClienteDbException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
