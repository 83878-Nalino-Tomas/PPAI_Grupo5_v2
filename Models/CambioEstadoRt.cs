using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class CambioEstadoRt
    {
        public int IdCambioRt { get; set; }
        public DateTime? FechaHoraDesde { get; set; }
        public DateTime? FechaHoraHasta { get; set; }
        public int? Estado { get; set; }
        public int? RecursoTecnologico { get; set; }

        public virtual Estado EstadoNavigation { get; set; }
        public virtual RecursoTecnologico RecursoTecnologicoNavigation { get; set; }
    }
}
