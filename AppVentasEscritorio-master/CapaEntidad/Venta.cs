﻿using System.Collections.Generic;

namespace CapaEntidad
{
    public class Venta
    {
        public List<Detalle_Venta> dvDetalleVenta { get; set; }
        public Producto pProducto { get; set; }
        public object IdProducto { get; set; }
        public int IdVenta { get; set; }
        public string DatosCliente { get; set; }
        public string Telefono { get; set; }
        public string Especificaciones { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorPagado { get; set; }
        public decimal ValorResta { get; set; }
        public decimal SubTotal { get; set; }
        public int Cantidad { get; set; }
        public string EstadoDeuda { get; set; }
        public string FechaRegistro { get; set; }
        public string NumeroConsecutivo { get; set; }
        public decimal ValorProducto { get; set; }
    }
}
