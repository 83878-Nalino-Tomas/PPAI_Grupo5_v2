using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class Estado
    {
        public Estado()
        {
            CambioEstadoRts = new HashSet<CambioEstadoRt>();
            CambioEstadoTurnos = new HashSet<CambioEstadoTurno>();
        }

        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ambito { get; set; }

        public virtual ICollection<CambioEstadoRt> CambioEstadoRts { get; set; }
        public virtual ICollection<CambioEstadoTurno> CambioEstadoTurnos { get; set; }
    }
}
