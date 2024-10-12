using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public class CD_Producto
{
    public List<Producto> ListarProductos()
    {
        List<Producto> lista = new List<Producto>();

        using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
        {
            try
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("select p.IdProducto,p.Codigo, p.Descripcion, p.PrecioVenta, p.estado, c.IdCategoria, c.Detalle from PRODUCTO p");
                query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria");

                SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                cmd.CommandType = CommandType.Text;


                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Producto()
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                            CodProducto = dr["Codigo"].ToString(),
                            DetalleProducto = dr["Descripcion"].ToString(),
                            PrecioVenta = Convert.ToInt32(dr["PrecioVenta"]),
                            Estado = Convert.ToBoolean(dr["Estado"]),
                            cCategoria = new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Detalle = dr["Detalle"].ToString()
                            }

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
    public int RegistrarProducto(Producto obj, out string Mensaje)
    {
        int idproducto = 0;
        Mensaje = string.Empty;

        try
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCategoria", obj.cCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", obj.CodProducto);
                cmd.Parameters.AddWithValue("@Descripcion", obj.DetalleProducto);
                cmd.Parameters.AddWithValue("@PrecioVenta", obj.PrecioVenta);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                // Parámetros de salida
                SqlParameter paramidproducto = new SqlParameter("@Idproducto", SqlDbType.Int);
                paramidproducto.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramidproducto);

                SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                paramMensaje.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramMensaje);

                oconexion.Open();
                cmd.ExecuteNonQuery();

                idproducto = Convert.ToInt32(paramidproducto.Value);
                Mensaje = paramMensaje.Value.ToString();
            }
        }
        catch (Exception ex)
        {
            idproducto = 0;
            Mensaje = ex.Message; // Aquí podrías loguear el error en lugar de solo asignarlo a Mensaje
        }
        return idproducto;
    }

    public bool EditarProducto(Producto obj, out string Mensaje)
    {
        bool respuesta = false;
        Mensaje = string.Empty;

        try
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProducto", obj.IdProducto);
                cmd.Parameters.AddWithValue("@IdCategoria", obj.cCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("@Codigo", obj.CodProducto);
                cmd.Parameters.AddWithValue("@Descripcion", obj.DetalleProducto);
                cmd.Parameters.AddWithValue("@PrecioVenta", obj.PrecioVenta);
                cmd.Parameters.AddWithValue("@Estado", obj.Estado);

                // Parámetros de salida
                SqlParameter paramRespuesta = new SqlParameter("@Respuesta", SqlDbType.Bit);
                paramRespuesta.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramRespuesta);

                SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                paramMensaje.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramMensaje);

                oconexion.Open();
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(paramRespuesta.Value);
                Mensaje = paramMensaje.Value.ToString();
            }
        }
        catch (Exception ex)
        {
            respuesta = false;
            Mensaje = "Error al editar Producto: " + ex.Message; // Aquí podrías loguear el error en lugar de solo asignarlo a Mensaje
        }
        return respuesta;
    }

    public bool EliminarProducto(Producto obj, out string Mensaje)
    {
        bool respuesta = false;
        Mensaje = string.Empty;

        try
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProducto", obj.IdProducto);

                // Parámetros de salida
                SqlParameter paramRespuesta = new SqlParameter("@Respuesta", SqlDbType.Bit);
                paramRespuesta.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramRespuesta);

                SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                paramMensaje.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramMensaje);

                oconexion.Open();
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(paramRespuesta.Value);
                Mensaje = paramMensaje.Value.ToString();
            }
        }
        catch (Exception ex)
        {
            respuesta = false;
            Mensaje = "Error al eliminar Producto: " + ex.Message; // Aquí podrías loguear el error en lugar de solo asignarlo a Mensaje
        }
        return respuesta;
    }

}
