using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Context;
using BusMonoliticApp.Web.Data.Exceptions;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class UsuarioDb : IUsuarioDb
    {
        private readonly BoletosBusContext context;

        public UsuarioDb(BoletosBusContext context)
        {
            this.context = context;
        }
        public List<UsuarioModel> GetUsuario()
        {
            return this.context.Usuario.Select(U => new UsuarioModel()
            {
                IdUsuario = U.IdUsuario,
                Nombres = U.Nombres,
                Apellidos = U.Apellidos,
                Correo = U.Correo,
                Clave = U.Clave,
                TipoUsuario = U.TipoUsuario,
                FechaCreacion = U.FechaCreacion,


            }).ToList();
        }

            public UsuarioModel GetUsuario(int IdUsuario)
        {
            var Usuario = this.context.Usuario.Find(IdUsuario);

            if (Usuario == null)
            {
                throw new UsuarioDbException("No se encontro al usuario con el Id proporcionado");
            }
            UsuarioModel model = new UsuarioModel()
            {
                IdUsuario = Usuario.IdUsuario,
                Nombres = Usuario.Nombres,
                Apellidos = Usuario.Apellidos,
                Correo = Usuario.Correo,
                Clave = Usuario.Clave,
                TipoUsuario = Usuario.TipoUsuario,
                FechaCreacion = Usuario.FechaCreacion,

            };
            return model;

        }

        public void SaveUsuario(UsuarioSaveModel SaveUsuario)
        {
            Usuario usuario = new Usuario()
            {
                
                Nombres = SaveUsuario.Nombres,
                Apellidos = SaveUsuario.Apellidos,
                Correo = SaveUsuario.Correo,
                Clave = SaveUsuario.Clave,
                TipoUsuario = SaveUsuario.TipoUsuario,
                FechaCreacion = SaveUsuario.FechaCreacion,

            };

            this.context.Usuario.Add(usuario);
            this.context.SaveChanges();
        }

        public void UpdateUsuario(UsuarioUpdateModel usuarioupdate)
        {
            Usuario cambio = this.context.Usuario.Find(usuarioupdate.IdUsuario);

            
            cambio.Nombres = usuarioupdate.Nombres;
            cambio.Apellidos = usuarioupdate.Apellidos;
            cambio.Correo = usuarioupdate.Correo;
            cambio.Clave = usuarioupdate.Clave;
            cambio.TipoUsuario = usuarioupdate.TipoUsuario;
            cambio.FechaCreacion = usuarioupdate.FechaCreacion;


            this.context.Usuario.Update(cambio);
            this.context.SaveChanges();
        }
        public void DeleteUsuario(UsuarioDeleteModel usuarioDelete)
        {
 

        }  
    }      
}          
           
           
           


           
           