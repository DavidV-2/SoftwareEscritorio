using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_DetalleVenta
    {
        private CD_DetalleVenta obj_detalleventa = new CD_DetalleVenta();
        public List<Detalle_Venta> Listar()
        {
            return obj_detalleventa.Listar();
        }
    }
}
