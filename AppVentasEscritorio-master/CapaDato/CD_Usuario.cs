using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace CapaDato
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave, u.Estado, r.IdRol,r.Descripcion from usuario u");
                    query.AppendLine("inner join ROL r on r.IdRol = u.IdRol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;


                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oRol = new Rol()
                                {
                                    IdRol = Convert.ToInt32(dr["IdRol"]),
                                    Descripcion = dr["Descripcion"].ToString()
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
        public int Registrar(Usuario obj, out string Mensaje)
        //procedimiento almacenado desde sql ejecucion de guardado directo a BD
        {
            int idUsuarioResultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("@Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("@IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    
                    // Parámetros de salida
                    SqlParameter paramidUsuarioResultado = new SqlParameter("@IdUsuarioResultado", SqlDbType.Int);
                    paramidUsuarioResultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramidUsuarioResultado);

                    SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idUsuarioResultado = Convert.ToInt32(paramidUsuarioResultado.Value);
                    Mensaje = paramMensaje.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idUsuarioResultado = 0;
                Mensaje = ex.Message;
            }
            return idUsuarioResultado;
        }
        public bool Editar(Usuario obj, out string Mensaje)
        //procedimiento almacenado desde sql
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("@Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("@NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("@Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("@Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("@IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    // Parámetros de salida
                    SqlParameter paramrespuesta = new SqlParameter("@Respuesta", SqlDbType.Bit);
                    paramrespuesta.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramrespuesta);

                    SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(paramrespuesta.Value);
                    Mensaje = paramMensaje.Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = "Error al editar el usuario: " + ex.Message;
            }
            return Respuesta;
        }
        public bool Eliminar(Usuario obj, out string Mensaje)
        //procedimiento almacenado desde sql
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdUsuario);

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
                Mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
