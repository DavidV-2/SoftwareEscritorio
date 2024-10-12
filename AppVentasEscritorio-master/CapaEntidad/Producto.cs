using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public object IdCategoria;
        public int IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string DetalleProducto { get; set; }
        public Categoria cCategoria { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }  
}
