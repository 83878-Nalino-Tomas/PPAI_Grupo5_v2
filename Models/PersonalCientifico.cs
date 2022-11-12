using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class PersonalCientifico
    {
        public PersonalCientifico()
        {
            AsignacionCientificoDelCis = new HashSet<AsignacionCientificoDelCi>();
        }

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public decimal? NumeroDocumento { get; set; }
        public string TelefonoCelular { get; set; }
        public int? Usuario { get; set; }

        public virtual Usuario UsuarioNavigation { get; set; }
        public virtual ICollection<AsignacionCientificoDelCi> AsignacionCientificoDelCis { get; set; }
    }
}
