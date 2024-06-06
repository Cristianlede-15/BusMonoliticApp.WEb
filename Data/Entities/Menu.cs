﻿using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Menu : BaseEntity
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? Categoria { get; set; }
    }
}
