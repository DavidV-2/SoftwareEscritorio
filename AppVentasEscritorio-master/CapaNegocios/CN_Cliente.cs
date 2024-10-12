using CapaDato;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CN_Cliente
    {

        private CD_Cliente objcd_cliente = new CD_Cliente();

        public List<Cliente> ListarClientes()
        {
            return objcd_cliente.Listar();
        }
    }
}
