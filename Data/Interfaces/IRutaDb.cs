using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.Web.Data.Models.RutaModelDB;


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