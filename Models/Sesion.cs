using System;
using System.Collections.Generic;

#nullable disable

namespace PPAI_Grupo5_v2.Models
{
    public partial class Sesion
    {
        public int IdSesion { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public int? Usuario { get; set; }

        public virtual Usuario UsuarioNavigation { get; set; }
    }
}
