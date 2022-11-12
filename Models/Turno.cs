using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class Turno
    {
        public Turno()
        {
            CambioEstadoTurnos = new HashSet<CambioEstadoTurno>();
        }

        public int IdTurno { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public int? DiaSemana { get; set; }
        public int? Asignacion { get; set; }

        public virtual AsignacionCientificoDelCi AsignacionNavigation { get; set; }
        public virtual ICollection<CambioEstadoTurno> CambioEstadoTurnos { get; set; }
    }
}
