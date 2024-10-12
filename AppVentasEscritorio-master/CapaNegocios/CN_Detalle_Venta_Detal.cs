using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_DetalleVentaDetal
    {
        private CD_Detalle_VentaDetal obj_detalleventadetal = new CD_Detalle_VentaDetal();
        public List<Detalle_VentaDetal> Listar()
        {
            return obj_detalleventadetal.Listar();
        }
    }
}
