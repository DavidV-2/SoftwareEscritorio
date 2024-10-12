using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato 
{
    public class CD_Detalle_VentaDetal
    {
        public List<Detalle_VentaDetal> Listar()
        {
            List<Detalle_VentaDetal> lista = new List<Detalle_VentaDetal>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select @IdVentaDetal,IdProducto,Producto,SubTotal,Cantidad,@NumeroConsecutivo from @DetalleVentaDetal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Detalle_VentaDetal()
                            {
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"]),
                                pdProducto = new ProductoDetal()
                                {
                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    Producto = dr["Producto"].ToString(),
                                },
                                
                            }); ;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                }
            }
            return lista;
        }
    }
}
