using AppVentasEscritorio;
using CapaDato;
using System;
using System.Collections.Generic;

namespace CapaNegocios
{
    public class CN_Evento
    {
        private CD_Evento cn_evento = new CD_Evento();
        // Lista los eventos guardados
        public List<Evento> Listar()
        {
            return cn_evento.Listar();
        }

    }
}
