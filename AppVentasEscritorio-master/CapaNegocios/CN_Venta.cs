using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocios
{
    public class CN_Venta
    {
        private CD_Venta objcd_Venta = new CD_Venta();

        public int ObtenerCorrelativo()
        {
            return objcd_Venta.ObtenerCorrelativo();
        }
        public bool RegistrarVentaMasiva(Venta obj,DataTable Detalle_Venta_Maviva, out string Mensaje)
        {
            return objcd_Venta.RegistrarVentaMasiva(obj, Detalle_Venta_Maviva, out Mensaje);
        }
        public Venta ObtenerVenta(string DatosCliente) {

            Venta vVenta = objcd_Venta.ObtenerVenta(DatosCliente);

            if(!string.IsNullOrEmpty(vVenta.DatosCliente)) {
                List<Detalle_Venta> dvDetalleVenta = objcd_Venta.ObtenerDetalleVenta(vVenta.DatosCliente);

                vVenta.dvDetalleVenta = dvDetalleVenta;
            }
            return vVenta;
        }
        /*
        public bool RestarStock(int IdProducto, int cantidad) //Procedimiento para actualizar un Stock de productos con BD en caso de necesitar
        {
            return objcd_Venta.RestarStock(IdProducto, cantidad);
        }*/
    }
}
