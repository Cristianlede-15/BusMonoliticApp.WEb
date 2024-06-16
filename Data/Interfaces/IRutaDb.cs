using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using BusTicketsMonolitic.Web.Data.Models.Ruta;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IRutaDb
    {
        void SaveRuta(RutaSaveModel saveModel);
        void UpdateRuta(RutaUpdateModel updateModel);
        void DeleteRuta(RutaDeleteModel deleteModel);
        List<RutaModelAccess> GetRutas();
        RutaModelAccess GetRutas(int IdRuta);
    }
}