using CapaDato;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objcd_categoria.Listar();
        }
        public int RegistrarCategoria(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Detalle == "")
            {
                Mensaje += "Es necesario Detallar la Categoria\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_categoria.RegistrarCategoria(obj, out Mensaje);
            }
        }
        public bool EditarCategoria(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Detalle == "")
            {
                Mensaje += "Es necesario Detallar la Categoria\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_categoria.EditarCategoria(obj, out Mensaje);
            }
        }
        public bool EliminarCategoria(Categoria obj, out string Mensaje)
        {
            return objcd_categoria.EliminarCategoria(obj, out Mensaje);
        }
    }
}
