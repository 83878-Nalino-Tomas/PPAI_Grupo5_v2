using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class CentroDeInvestigacion
    {
        public CentroDeInvestigacion()
        {
            AsignacionCientificoDelCis = new HashSet<AsignacionCientificoDelCi>();
            RecursoTecnologicos = new HashSet<RecursoTecnologico>();
        }

        public int IdCentro { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CorreoElectronico { get; set; }
        public string TelefonoContacto { get; set; }
        public string NumeroResolucionCreacion { get; set; }

        public virtual ICollection<AsignacionCientificoDelCi> AsignacionCientificoDelCis { get; set; }
        public virtual ICollection<RecursoTecnologico> RecursoTecnologicos { get; set; }
    }
}
