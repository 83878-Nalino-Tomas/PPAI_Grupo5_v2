using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class TipoRt
    {
        public TipoRt()
        {
            RecursoTecnologicos = new HashSet<RecursoTecnologico>();
        }

        public int IdTipoRt { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<RecursoTecnologico> RecursoTecnologicos { get; set; }
    }
}
