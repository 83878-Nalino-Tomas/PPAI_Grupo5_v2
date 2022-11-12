using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class AsignacionCientificoDelCi
    {
        public AsignacionCientificoDelCi()
        {
            Turnos = new HashSet<Turno>();
        }

        public int IdAsignacion { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? PersonalCientifico { get; set; }
        public int? CentroInvestigacion { get; set; }

        public virtual CentroDeInvestigacion CentroInvestigacionNavigation { get; set; }
        public virtual PersonalCientifico PersonalCientificoNavigation { get; set; }
        public virtual ICollection<Turno> Turnos { get; set; }
    }
}
