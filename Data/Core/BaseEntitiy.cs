namespace BusTicketsMonolitic.Web.Data.Core
{
    public abstract class BaseEntitiy
    {
        protected BaseEntitiy() {
            this.FechaCreacion = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime? FechaCreacion { get; set; }
        
    }
}
