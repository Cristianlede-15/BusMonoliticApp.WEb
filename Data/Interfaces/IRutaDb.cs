using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using BusMonoliticApp.Web.Data.Models.Ruta;


namespace BusMonoliticApp.Web.Data.Interfaces
{
    public interface IRutaDb
    {
        void SaveRuta(RutaSaveModel RutaSaveModel);
        void UpdateRuta(RutaUpdateModel RutaUpdateModel);
        void DeleteRuta(RutaDeleteModel RutaDeleteModel);
        List<RutaModelAccess> GetRutas();
        RutaModelAccess GetRutas(int IdRuta);
    }
}