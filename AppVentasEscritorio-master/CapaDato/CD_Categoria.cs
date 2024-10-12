using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDato
{
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdCategoria, Detalle, Estado from CATEGORIA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Detalle = dr["Detalle"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }

        public int RegistrarCategoria(Categoria obj, out string Mensaje)
        //procedimiento almacenado desde sql ejecucion de guardado directo a BD
        {
            int idcategoria = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Detalle", obj.Detalle);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);

                    // Parámetros de salida
                    SqlParameter paramResultado = new SqlParameter("@Resultado", SqlDbType.Int);
                    paramResultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idcategoria = Convert.ToInt32(paramResultado.Value);
                    Mensaje = paramMensaje.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idcategoria = 0;
                Mensaje = ex.Message;
            }
            return idcategoria;
        }
        public bool EditarCategoria(Categoria obj, out string Mensaje)
        //procedimiento almacenado desde sql
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarCategoria", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdCategoria", obj.IdCategoria);
                    cmd.Parameters.AddWithValue("@Detalle", obj.Detalle);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);


                    // Parámetros de salida
                    SqlParameter paramResultado = new SqlParameter("@Resultado", SqlDbType.Bit);
                    paramResultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Resultado = Convert.ToBoolean(paramResultado.Value);
                    Mensaje = paramMensaje.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Resultado = false;
                Mensaje = "Error al editar Categoria: " + ex.Message;
            }
            return Resultado;
        }
        public bool EliminarCategoria(Categoria obj, out string Mensaje)
        //procedimiento almacenado desde sql
        {
            bool Resultado = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCategoria", obj.IdCategoria);


                    SqlParameter paramResultado = new SqlParameter("@Resultado", SqlDbType.Bit);
                    paramResultado.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramResultado);

                    SqlParameter paramMensaje = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Resultado = Convert.ToBoolean(paramResultado.Value);
                    Mensaje = paramMensaje.Value.ToString();

                }
            }
            catch (Exception ex)
            {
                Resultado = false;
                Mensaje = ex.Message;
            }
            return Resultado;
        }
    }
}
