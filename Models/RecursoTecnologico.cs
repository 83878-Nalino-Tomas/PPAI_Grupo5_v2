using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class RecursoTecnologico
    {
        public RecursoTecnologico()
        {
            CambioEstadoRts = new HashSet<CambioEstadoRt>();
        }

        public int NumeroRt { get; set; }
        public DateTime? FechaAlta { get; set; }
        public int? DuracionMantenimiento { get; set; }
        public int? PeriodicidadMantenimiento { get; set; }
        public int? TipoDeRt { get; set; }
        public int? ModeloDelRt { get; set; }
        public int? CentroInvestigacion { get; set; }

        public virtual CentroDeInvestigacion CentroInvestigacionNavigation { get; set; }
        public virtual Modelo ModeloDelRtNavigation { get; set; }
        public virtual TipoRt TipoDeRtNavigation { get; set; }
        public virtual ICollection<CambioEstadoRt> CambioEstadoRts { get; set; }
    }
}
