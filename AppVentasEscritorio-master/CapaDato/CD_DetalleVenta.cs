using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDato
{
    public class CD_DetalleVenta
    {
        public List<Detalle_Venta> Listar()
        {
            List<Detalle_Venta> lista = new List<Detalle_Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProducto,CodProducto,DetalleProducto,DatosCliente,Telefono,Especificaciones," +
                        "ValorVenta,ValorPagado,ValorResta,SubTotal,Cantidad,EstadoDeuda,@IdVenta from @DetalleVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Detalle_Venta()
                            {                         
                                IdDetalleVenta = Convert.ToInt32(dr["IdDetalleVenta"]),
                                DatosCliente = dr["DatosCliente"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Especificaciones = dr["Especificaciones"].ToString(),
                                ValorVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                ValorPagado = Convert.ToDecimal(dr["ValorPagado"]),
                                ValorResta = Convert.ToDecimal(dr["ValorResta"]),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"]),
                                EstadoDeuda = dr["EstadoDeuda"].ToString(),
                                pProducto = new Producto()
                                {
                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    CodProducto =dr["CodProducto"].ToString(),
                                    DetalleProducto = dr["DetalleProducto"].ToString(),
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
