using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            PersonalCientificos = new HashSet<PersonalCientifico>();
            Sesions = new HashSet<Sesion>();
        }

        public int IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public bool? Habilitado { get; set; }

        public virtual ICollection<PersonalCientifico> PersonalCientificos { get; set; }
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
