using BusMonoliticApp.Web.Data.Interfaces;
using BusMonoliticApp.Web.Data.Models;
using BusMonoliticApp.WEb.Data.Models;
using BusMonoliticApp.Web.Data.Entities;
using BusMonoliticApp.Web.Data.Context;

namespace BusMonoliticApp.Web.Data.DbObjects
{
    public class UsuarioDb : IUSuarioDb
    {
        private readonly BoletosBusContext context;

        public UsuarioDb(BoletosBusContext context)
        {
            this.context = context;
        }

        public void DeleteUsuario(UsuarioDeleteModel DeleteUsuario)
        {
            var usuario = context.Usuario.Find(UsuarioDeleteModel.Id);
            if (usuario == null)
                throw new KeyNotFoundException("Usuario not found");

            context.Usuario.Remove(usuario);
            context.SaveChanges();
        }

        public List<UsuarioModel> GetUsuario()
        {
                return context.Usuario
                .Select(usuario => new UsuarioModel
                {
                    Nombres = usuario.Nombres,
                    Apellido = usuario.Apellidos,
                    TipoUsuario = usuario.TipoUsuario,
                    FechaCreacion = usuario.FechaCreacion
                })
                .ToList();
        }

        public UsuarioModel GetUsuario(string? Nombres)
        {
            var usuario = context.Usuario.FirstOrDefault(u => u.Nombres == Nombres);
            if (usuario == null)
                throw new KeyNotFoundException("Usuario not found");

            return new UsuarioModel
            {
                Nombres = usuario.Nombres,
                Apellido = usuario.Apellidos,
                TipoUsuario = usuario.TipoUsuario,
                FechaCreacion = usuario.FechaCreacion
            };
        }

        public void SaveUsuario(UsuarioSaveModel SaveUsuario)
        {
            var usuarioEntity = new Usuario
            {
                Nombres = SaveUsuario.Nombres,
                Apellidos = SaveUsuario.Apellido,
                TipoUsuario = SaveUsuario.TipoUsuario,
                FechaCreacion = SaveUsuario.FechaCreacion
            };

            context.Usuario.Add(usuarioEntity);
            context.SaveChanges();
        }

        public void UpdateUsuario(UsuarioUpdateModel UpdateUsuario)
        {
            var usuario = context.Usuario.FirstOrDefault(u => u.Nombres == UpdateUsuario.Nombres);
            if (usuario == null)
                throw new KeyNotFoundException("Usuario not found");

            usuario.Apellidos = UpdateUsuario.Apellido;
            usuario.TipoUsuario = UpdateUsuario.TipoUsuario;
            usuario.ModifyDate = UpdateUsuario.ModifyDate;

            context.Usuario.Update(usuario);
            context.SaveChanges();
        }
    }
}
