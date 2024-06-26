﻿using BusMonoliticApp.Web.Data.Core;

namespace BusMonoliticApp.Web.Data.Entities
{
    public class Viaje : BaseEntity
    {
        public int? IdBus { get; set; }
        public int? IdRuta { get; set; }
        public DateTime? FechaSalida { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public TimeSpan? HoraLlegada { get; set; }
        public decimal? Precio { get; set; }
        public int? TotalAsientos { get; set; }
        public int? AsientosReservados { get; set; }
        public int AsientoDisponibles => (TotalAsientos ?? 0) - (AsientosReservados ?? 0);
        public bool Completo => AsientoDisponibles < 1;
    }
}
