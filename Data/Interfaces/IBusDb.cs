using BusMonoliticApp.Web.Data.Entities;

namespace BusTicketsMonolitic.Web.Data.Interfaces
{
    public interface IBusDb
    {
        void Save(Bus bus) { }
    }
}
