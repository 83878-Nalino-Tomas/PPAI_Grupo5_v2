using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class CambioEstadoTurno
    {
        public int IdCambioTurno { get; set; }
        public DateTime? FechaHoraDesde { get; set; }
        public DateTime? FechaHoraHasta { get; set; }
        public int? Estado { get; set; }
        public int? Turno { get; set; }

        public virtual Estado EstadoNavigation { get; set; }
        public virtual Turno TurnoNavigation { get; set; }
    }
}
