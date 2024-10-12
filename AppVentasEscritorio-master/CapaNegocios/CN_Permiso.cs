using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_permiso = new CD_Permiso();

        public List<Permiso> Listar(int IdUsuario)
        {
            return objcd_permiso.Listar(IdUsuario);
        }
    }
}
