using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class Modelo
    {
        public Modelo()
        {
            RecursoTecnologicos = new HashSet<RecursoTecnologico>();
        }

        public int IdModelo { get; set; }
        public string Nombre { get; set; }
        public int? Marca { get; set; }

        public virtual Marca MarcaNavigation { get; set; }
        public virtual ICollection<RecursoTecnologico> RecursoTecnologicos { get; set; }
    }
}
