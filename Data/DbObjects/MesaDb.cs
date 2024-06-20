using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;

namespace BusMonoliticApp.Web.Data.DbObjects
{

    public class MesaDb : IMesaDb
    {
        private readonly BoletosBusContext context;

        public MesaDb(BoletosBusContext context)
        {
            this.context = context;
        }

        public List<MesaModel> GetMesa()
        {
            return this.context.Mesa.Select(M => new MesaModel()
            {
                IdMesa = M.IdMesa,
                Capacidad = M.Capacidad,
                Estado = M.Estado,

            }).ToList();

        }

        public MesaModel GetMesa(int IdMesa)
        {
            var Mesa = this.context.Mesa.Find(IdMesa);
            
            MesaModel mesa = new MesaModel()
            {

                IdMesa = Mesa.IdMesa,
                Capacidad = Mesa.Capacidad,
                Estado = Mesa.Estado,
            };
            return mesa;
        }

        public void SaveMesa(MesaSaveModel SaveMesa)
        {
            Mesa mesa = new Mesa()
            {
                IdMesa = SaveMesa.IdMesa,
                Capacidad = SaveMesa.Capacidad,
                Estado = SaveMesa.Estado,
        

            };

            this.context.Mesa.Add(mesa);
            this.context.SaveChanges();
        }

        public void UpdateMesa(MesaUpdateModel UpdateMesa)
        {
            Mesa MesaUpdate = this.context.Mesa.Find(UpdateMesa.IdMesa);

            UpdateMesa.IdMesa = UpdateMesa.IdMesa;
            UpdateMesa.Capacidad = UpdateMesa.Capacidad;
            UpdateMesa.Estado = UpdateMesa.Estado;



            this.context.Mesa.Update(MesaUpdate);
            this.context.SaveChanges();
        }
        public void DeleteMenu(MesaDeleteModel DeleteMesa)
        {
            throw new NotImplementedException();
        }
    }
}
