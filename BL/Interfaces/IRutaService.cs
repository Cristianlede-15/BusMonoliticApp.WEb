using BusMonoliticApp.Web.Data.Models.Ruta;
using BusMonoliticApp.Web.Data.Models.RutaModelDB;
using BusTicketsMonolitic.Web.BL.Core;

namespace BusTicketsMonolitic.Web.BL.Interfaces
{
    public interface IRutaService
    {
        ServiceResult GetRutas();
        ServiceResult GetRutas(int id);
        ServiceResult UpDateRutas(RutaUpdateModel rutaUpdateModel);
        ServiceResult DeleteRuta(RutaDeleteModel rutaDeleteModel);
        ServiceResult SaveRuta(RutaSaveModel rutaSaveModel);
    }
}
