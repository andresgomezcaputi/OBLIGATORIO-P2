using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    class Usuario
    {

        private static int UltimoIdUsuario = 1;
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento  { get; set; }

        public Usuario(string nombre, string apellido, string email, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            IdUsuario = UltimoIdUsuario;
            UltimoIdUsuario++;
        }
    }
}
