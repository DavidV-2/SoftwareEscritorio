using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int IdDetalleVenta { get; set; }
        public Producto pProducto { get; set; }
        public string DatosCliente { get; set; }
        public string Telefono { get; set; }
        public string Especificaciones { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal ValorPagado { get; set; }
        public decimal ValorResta { get; set; }
        public decimal SubTotal { get; set; }
        public string EstadoDeuda { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
