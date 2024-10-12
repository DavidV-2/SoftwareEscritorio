using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace CapaEntidad
{
    public class Venta_Detal
    {
        public ProductoDetal pdProducto { get; set; }
        public string IdProducto { get; set; }
        public int IdVentaDetal { get; set; }
        public string NumeroConsecutivo { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public decimal PrecioVenta { get; set; }       
        public string FechaRegistro { get; set; }
        public List<Detalle_VentaDetal> dvdDetalleDetal { get; set; }
        
    }
}
