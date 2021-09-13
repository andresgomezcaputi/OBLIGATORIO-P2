using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    class Actividad
    {
        private static int UltimoIdActividad = 1;
        public int IdActividad { get; set; }
        public string   Nombre{ get; set; }

        public Categoria Categoria { get; set; }

        public DateTime FechaHora { get; set; }
        public Lugar Lugar { get; set; }

        public string EdadMinima { get; set; }

        public static double PrecioBaseEntrada { get; }
        public int MeGusta { get; set; }

        public Actividad(string nombre, Categoria categoria, DateTime fechaHora, Lugar lugar, string edadMinima, int meGusta)
        {
            Nombre = nombre;
            Categoria = categoria;
            FechaHora = fechaHora;
            Lugar = lugar;
            EdadMinima = edadMinima;
            MeGusta = meGusta;
            IdActividad = UltimoIdActividad;
            UltimoIdActividad++;
        }
    }
}
