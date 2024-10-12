using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace CapaDato
{
    public class CD_Venta_Detal
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Venta_Detal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {

                    return idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }
        /* 
        public bool RestarStock(int IdProducto, int cantidad) //Procedimiento para actualizar un Stock de productos con BD en caso de necesitar
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where IdProducto = @IdProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();


                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {

                    return respuesta;
                }
            }
            return respuesta;
        }*/
        public bool Registrar(Venta_Detal obj, DataTable Detalle_Venta_Detal, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistroVentaDetal", oconexion);

                    cmd.Parameters.AddWithValue("@NumeroConsecutivo", obj.NumeroConsecutivo);
                    cmd.Parameters.AddWithValue("@IdProducto", obj.pdProducto.IdProducto);
                    cmd.Parameters.AddWithValue("@Producto", obj.pdProducto.Producto);
                    cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                    cmd.Parameters.AddWithValue("@SubTotal", obj.pdProducto.PrecioVenta);
                    cmd.Parameters.AddWithValue("@DetalleVentaDetal", Detalle_Venta_Detal);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }

        public Venta_Detal ObtenerVentaDetal(string numeroConsecutivo)
        {
            Venta_Detal ventaDetal = new Venta_Detal();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder(); // CONSULTA QUE PERMITE MOSTRAR LOS DETALLES DE LA VENTA          
                    query.AppendLine("SELECT VD.IdVentaDetal,");
                    query.AppendLine("VD.NumeroConsecutivo,");
                    query.AppendLine("DVD.Producto,");
                    query.AppendLine("DVD.Cantidad,");
                    query.AppendLine("DVD.SubTotal,");
                    query.AppendLine("CONVERT (char(10), DVD.FechaRegistro, 103) AS FechaRegistro");
                    query.AppendLine("FROM VENTA_DETAL VD ");
                    query.AppendLine("INNER JOIN DETALLE_VENTA_DETAL DVD  ON DVD.IdVentaDetal = VD.IdVentaDetal");
                    query.AppendLine("WHERE VD.NumeroConsecutivo = @NumeroConsecutivo;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@NumeroConsecutivo", numeroConsecutivo);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ventaDetal = new Venta_Detal()
                            {
                                IdVentaDetal = Convert.ToInt32(dr["IdVentaDetal"]),
                                NumeroConsecutivo = dr["NumeroConsecutivo"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error en ObtenerVentaDetal: " + ex.Message);
                    ventaDetal = new Venta_Detal();
                }
            }
            return ventaDetal;
        }
        public List<Detalle_VentaDetal> ObtenerDetalleVentaDetal(int NumeroConsecutivo)
        {
            List<Detalle_VentaDetal> dvlista = new List<Detalle_VentaDetal>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT pd.Producto, dvd.Cantidad,dvd.SubTotal FROM DETALLE_VENTA_DETAL dvd");
                    query.AppendLine("INNER JOIN PRODUCTO_DETAL pd ON pd.IdProducto = dvd.IdProducto");
                    query.AppendLine("INNER JOIN VENTA_DETAL vd ON vd.IdVentaDetal = dvd.IdVentaDetal");
                    query.AppendLine("WHERE dvd.NumeroConsecutivo = @NumeroConsecutivo;");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@NumeroConsecutivo", NumeroConsecutivo);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear objeto Detalle_VentaDetal y agregar a la lista del gvdata
                            dvlista.Add(new Detalle_VentaDetal()
                            {
                                pdProducto = new ProductoDetal() { Producto = dr["Producto"].ToString() },                               
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error en ObtenerDetalleVenta: " + ex.Message);
                dvlista = new List<Detalle_VentaDetal>(); // Reiniciar la lista en caso de error
            }
            return dvlista;
        }
    }
}
