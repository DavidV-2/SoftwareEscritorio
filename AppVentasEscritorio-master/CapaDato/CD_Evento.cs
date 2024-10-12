using AppVentasEscritorio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDato
{
    public class CD_Evento
    {
        public List<Evento> Listar()
        {
            List<Evento> lista = new List<Evento>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdEvento,FechaEvento,DatosCliente,Telefono,Direccion,DescripcionEvento,DetalleProducto,ValorVenta,");
                    query.AppendLine("ValorPagado, ValorResta, Estado FROM EVENTO");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Evento()
                            {
                                IdEvento = Convert.ToInt32(dr["IdEvento"]),
                                FechaEvento = dr["FechaEvento"].ToString(),
                                DatosCliente = dr["DatosCliente"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                DescripcionEvento = dr["DescripcionEvento"].ToString(),
                                ValorVenta = Convert.ToDecimal(dr["ValorVenta"]),
                                ValorPagado = Convert.ToDecimal(dr["ValorPagado"]),
                                ValorResta = Convert.ToDecimal(dr["ValorResta"]),
                                Estado = Convert.ToBoolean(dr["Estado"]),

                            });
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
