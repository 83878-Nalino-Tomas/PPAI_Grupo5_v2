using PPAI_Grupo5_v2.Models;
using System;

namespace PPAI_Grupo5_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DSI2022v2Context())
            {
                //    var user = new Usuario()
                //    {
                //        Habilitado = true,
                //        Clave = "admin123",
                //        Usuario1 = "ramonroldan",
                //    };
                //    context.Usuarios.Add(user);
                //    context.SaveChanges();

                var cientifico1 = new PersonalCientifico()
                {
                    Nombre = "Ramon",
                    Apellido = "Roldan",
                    NumeroDocumento = 23392569,
                    Correo = "ramonroldan@gmail.com",
                    TelefonoCelular = "23392569",
                    Legajo = 83877,
                    Usuario = 2
                };
                context.PersonalCientificos.Add(cientifico1);
                context.SaveChanges();

                //var sesionActual = new Sesion()
                //{
                //    FechaHoraInicio = DateTime.Now,
                //    FechaHoraFin = DateTime.Now.AddHours(2),
                //    Usuario = user.IdUsuario
                //};
                //context.Sesions.Add(sesionActual);
                //context.SaveChanges();

            }
        }
    }
}