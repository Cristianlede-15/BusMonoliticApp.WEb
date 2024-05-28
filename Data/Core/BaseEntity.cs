namespace BusMonoliticApp.Web.Data.Core
{
    public abstract class BaseEntity
    { 
        public int Id { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
