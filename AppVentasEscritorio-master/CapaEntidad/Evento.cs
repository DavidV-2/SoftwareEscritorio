using CapaEntidad;
using System;

namespace AppVentasEscritorio
{
    public class Evento
    {
        public object IdEvento;
        public string FechaEvento {  get; set; }
        public string DatosCliente { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string DescripcionEvento { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorPagado { get; set; }
        public decimal ValorResta { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
