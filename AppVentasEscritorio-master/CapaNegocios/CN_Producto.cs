using CapaDato;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();

        public List<Producto> ListarProductos()
        {
            return objcd_Producto.ListarProductos();
        }
        //procedimientos almacenados para btns 
        public int RegistrarProducto(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.CodProducto == "")
            {
                Mensaje += "Es necesario el Codigo del Producto\n";
            }

            if (obj.DetalleProducto == "")
            {
                Mensaje += "Es necesario el Nombre del Producto\n";
            }
            if (obj.PrecioVenta <= 0)
            {
                Mensaje += "Es necesario la Precio de Venta del Producto\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Producto.RegistrarProducto(obj, out Mensaje);
            }
        }
        public bool EditarProducto(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.CodProducto == "")
            {
                Mensaje += "Es necesario el Codigo del Producto\n";
            }

            if (obj.DetalleProducto == "")
            {
                Mensaje += "Es necesario el Nombre del Producto\n";
            }
            if (obj.PrecioVenta == 0)
            {
                Mensaje += "Es necesario la Precio de Venta del Producto\n";
            }
            if (Mensaje != string.Empty)
            { 
            return false;
            }
            else
            {
                return objcd_Producto.EditarProducto(obj, out Mensaje);
            }
        }
        public bool EliminarProducto(Producto obj, out string Mensaje)
        {
            return objcd_Producto.EliminarProducto(obj, out Mensaje);
        }
    }
}
    
