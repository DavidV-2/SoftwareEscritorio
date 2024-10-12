using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDato
{
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "select IdCliente,NombreCompleto, Correo, Telefono, EstadoDeuda FROM cliente";

                using (SqlCommand cmd = new SqlCommand(query, oconexion))
                {
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                EstadoDeuda = dr["EstadoDeuda"].ToString(),
                            };
                            lista.Add(cliente);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
