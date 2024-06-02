using BusMonoliticApp.Web.Data.Context;

namespace BusTicketsMonolitic.Web.Data.DbObjects.Dataconsultation
{
    public abstract class ClaseBaseConsultas<EP,Modelo,PrKey>
    {
        protected readonly BoletosBusContext context;

        public ClaseBaseConsultas(BoletosBusContext context)
        {
            this.context = context;
        }

        public abstract void Delete(PrKey key);
        public abstract List<Modelo> GetAll();
        public abstract Modelo GetById(PrKey key);
        public abstract void Save(EP entity);
        public abstract void Update(EP entity);
    }
}
