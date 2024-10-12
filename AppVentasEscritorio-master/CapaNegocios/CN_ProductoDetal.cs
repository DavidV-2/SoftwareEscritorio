using CapaDato;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_ProductoDetal
    {
        private CD_ProductoDetal objcd_ProductoDetal = new CD_ProductoDetal();

        public List<ProductoDetal> Listar()
        {
            return objcd_ProductoDetal.Listar();
        }
    }
}
