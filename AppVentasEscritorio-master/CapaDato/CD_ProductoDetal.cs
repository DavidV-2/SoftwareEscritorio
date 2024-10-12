using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class CD_ProductoDetal
    {
        public List<ProductoDetal> Listar()
        {
            List<ProductoDetal> lista = new List<ProductoDetal>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProducto,Producto,PrecioVenta FROM PRODUCTO_DETAL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ProductoDetal()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Producto = dr["Producto"].ToString(),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                    lista = new List<ProductoDetal>();
                }
            }
            return lista;
        }
    }
}
