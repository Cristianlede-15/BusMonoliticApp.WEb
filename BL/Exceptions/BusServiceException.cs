namespace BusTicketsMonolitic.Web.BL.Exceptions
{
    public class BusServiceException : Exception
    {
        public BusServiceException(string message) : base(message) { }
    }
}
