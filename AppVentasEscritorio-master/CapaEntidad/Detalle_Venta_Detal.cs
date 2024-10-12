using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_VentaDetal
    {
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public ProductoDetal pdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
        
    }
}
