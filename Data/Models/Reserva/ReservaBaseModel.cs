﻿namespace BusTicketsMonolitic.Web.Data.Models.Reserva
{
    public abstract class ReservaBaseModel
    {
        public int? IdViaje { get; set; }
        public int? IdPasajero { get; set; }
        //public int AsientosReservados { get; set; }
        //public decimal MontoTotal { get; set; }
        //public DateTime FechaCreacion { get; set; }
    }
}
