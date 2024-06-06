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

        public void DeleteMenu(MesaDeleteModel DeleteMesa)
        {
                        var mesa = context.Mesa.Find(DeleteMesa.IdMesa);
            if (mesa == null)
                throw new KeyNotFoundException("Mesa not found");

            context.Mesa.Remove(mesa);
            context.SaveChanges();
        }

        public List<MesaModel> GetMesa()
        {
                        return context.Mesa
                .Select(mesa => new MesaModel
                {
                    IdMesa = mesa.Id,
                    Capacidad = mesa.Capacidad,
                    Estado = mesa.Estado
                })
                .ToList();
        }

        public MesaModel GetMesa(int IdMesa)
        {
                        var mesa = context.Mesa.Find(IdMesa);
            if (mesa == null)
                throw new KeyNotFoundException("Mesa not found");

            return new MesaModel
            {
                IdMesa = mesa.Id,
                Capacidad = mesa.Capacidad,
                Estado = mesa.Estado
            };
        }

        public void SaveMesa(MesaSaveModel SaveMesa)
        {
            var mesaEntity = new Mesa
            {
                Capacidad = SaveMesa.Capacidad,
                Estado = SaveMesa.Estado
            };

            context.Mesa.Add(mesaEntity);
            context.SaveChanges();
        }

        public void UpdateMesa(MesaUpdateModel UpdateMesa)
        {
            var mesa = context.Mesa.Find(UpdateMesa.IdMesa);
            if (mesa == null)
                throw new KeyNotFoundException("Mesa not found");

            mesa.Capacidad = UpdateMesa.Capacidad;
            mesa.Estado = UpdateMesa.Estado;

            context.Mesa.Update(mesa);
            context.SaveChanges();
        }
    }
}
