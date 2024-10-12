using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

public class CD_Venta
{
    public int ObtenerCorrelativo()
    {
        int idcorrelativo = 0;

        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("select count(*) + 1 from Venta");

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
                query.AppendLine("update producto set stock = stock - @cantidad where IdProdcuto = @IdProducto");
                SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@IdProducto", IdProdcuto);
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
    }
    */
    public bool RegistrarVentaMasiva(Venta obj, DataTable Detalle_Venta_Maviva, out string Mensaje)
    {
        bool Respuesta = false;
        Mensaje = string.Empty;
        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_RegistroVentaMasiva", oconexion);

                cmd.Parameters.AddWithValue("@IdProducto", obj.pProducto.IdProducto);
                cmd.Parameters.AddWithValue("@CodProducto", obj.pProducto.CodProducto);
                cmd.Parameters.AddWithValue("@DetalleProducto", obj.pProducto.DetalleProducto);
                cmd.Parameters.AddWithValue("@DatosCliente", obj.DatosCliente);
                cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
                cmd.Parameters.AddWithValue("@Especificaciones", obj.Especificaciones);
                cmd.Parameters.AddWithValue("@ValorVenta", obj.ValorVenta);
                cmd.Parameters.AddWithValue("@ValorPagado", obj.ValorPagado);
                cmd.Parameters.AddWithValue("@ValorResta", obj.ValorResta);
                cmd.Parameters.AddWithValue("@SubTotal", obj.SubTotal);
                cmd.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                cmd.Parameters.AddWithValue("@EstadoDeuda", obj.EstadoDeuda);
                cmd.Parameters.AddWithValue("@NumeroConsecutivo", obj.NumeroConsecutivo);
                cmd.Parameters.AddWithValue("@DetalleVenta", Detalle_Venta_Maviva);
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

    public Venta ObtenerVenta(string DatosCliente)
    {
        Venta obj = new Venta();

        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        {
            try
            {
                StringBuilder query = new StringBuilder(); // Consulta SQL para obtener los detalles de la venta
                query.AppendLine("SELECT v.IdVenta,");
                query.AppendLine("v.NumeroConsecutivo,");
                query.AppendLine("dv.DatosCliente,");
                query.AppendLine("dv.Especificaciones,");
                query.AppendLine("dv.ValorVenta,");
                query.AppendLine("v.ValorPagado,");
                query.AppendLine("v.ValorResta,");
                query.AppendLine("v.SubTotal,");
                query.AppendLine("dv.EstadoDeuda,");
                query.AppendLine("CONVERT(char(10), v.FechaRegistro, 103) AS FechaRegistro");
                query.AppendLine("FROM VENTA v");
                query.AppendLine("INNER JOIN DETALLE_VENTA dv ON dv.IdVenta = v.IdVenta");
                query.AppendLine("WHERE v.DatosCliente = @DatosCliente");

                SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                cmd.Parameters.AddWithValue("@DatosCliente", DatosCliente);
                cmd.CommandType = CommandType.Text;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        obj = new Venta()
                        {
                            IdVenta = Convert.ToInt32(dr["IdVenta"]),
                            NumeroConsecutivo = dr["NumeroConsecutivo"].ToString(),
                            DatosCliente = dr["DatosCliente"].ToString(),
                            Especificaciones = dr["Especificaciones"].ToString(),
                            ValorPagado = Convert.ToDecimal(dr["ValorPagado"]),
                            ValorResta = Convert.ToDecimal(dr["ValorResta"]),
                            SubTotal = Convert.ToDecimal(dr["SubTotal"]),
                            EstadoDeuda = dr["EstadoDeuda"].ToString(),
                            FechaRegistro = dr["FechaRegistro"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error en ObtenerVenta: " + ex.Message);
                obj = new Venta(); // Reiniciar el objeto en caso de error
            }
        }

        return obj;
    }

    public List<Detalle_Venta> ObtenerDetalleVenta(string DatosCliente)
    {
        List<Detalle_Venta> dvlista = new List<Detalle_Venta>();
        try
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                oconexion.Open();

                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT p.Descripcion, p.PrecioVenta, v.ValorPagado, v.ValorResta, v.SubTotal, dv.Cantidad from DETALLE_VENTA dv");
                query.AppendLine("INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto");
                query.AppendLine("INNER JOIN VENTA v ON v.IdVenta = dv.IdVenta");
                query.AppendLine("WHERE dv.DatosCliente = @DatosCliente;");


                SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                cmd.Parameters.AddWithValue("@DatosCliente", DatosCliente);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        dvlista.Add(new Detalle_Venta()
                        {
                            pProducto = new Producto() {
                                DetalleProducto = dr["Descripcion"].ToString(),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString())                            
                            },                          
                            ValorPagado = Convert.ToDecimal(dr["ValorPagado"].ToString()),
                            ValorResta = Convert.ToDecimal(dr["ValorResta"].ToString()),
                            SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                            Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),

                        });
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Error en ObtenerDetalleVenta: " + ex.Message);
            dvlista = new List<Detalle_Venta>();
        }
        return dvlista;
    }
}
