using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Venta_Detal
    {
        private CD_Venta_Detal objcd_VentaDetal = new CD_Venta_Detal();

        public int ObtenerCorrelativo()
        {
            return objcd_VentaDetal.ObtenerCorrelativo();
        }
        public bool Registrar(Venta_Detal obj, DataTable Detalle_Venta_Detal, out string Mensaje)
        {
            return objcd_VentaDetal.Registrar(obj, Detalle_Venta_Detal, out Mensaje);
        }
        public Venta_Detal ObtenerVentaDetal(string numeroConsecutivo) {

            Venta_Detal vdVentaDetal= objcd_VentaDetal.ObtenerVentaDetal(numeroConsecutivo);

            if (!string.IsNullOrEmpty(vdVentaDetal.NumeroConsecutivo))
            {
                List<Detalle_VentaDetal> dvdDetalleVentaDetal = objcd_VentaDetal.ObtenerDetalleVentaDetal(vdVentaDetal.IdVentaDetal);

                vdVentaDetal.dvdDetalleDetal = dvdDetalleVentaDetal;
            }
            return vdVentaDetal;
        }
        /*
        public bool RestarStock(int IdProducto, int cantidad) //Procedimiento para actualizar un Stock de productos con BD en caso de necesitar
        {
            return objcd_Venta.RestarStock(IdProducto, cantidad);
        }*/
    }
}
