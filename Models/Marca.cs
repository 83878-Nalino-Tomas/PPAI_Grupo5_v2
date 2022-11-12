using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Modelos = new HashSet<Modelo>();
        }

        public int IdMarca { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Modelo> Modelos { get; set; }
    }
}
