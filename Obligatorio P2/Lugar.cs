using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    class Lugar
    {
        private static int UltimoIdLugar = 1;
        public int IdLugar { get; set; }
        public string Nombre { get; set; }
        public double MtsCuadrados { get; set; }
        public bool Tipo { get; set; }

        public static double PrecioButaca { get; }

        public bool Accesibilidad { get; set; }
        public double Mantenimiento { get; set; }
        public int AforoNativo { get; set; }

        public int AforoPermitido { get; set; }

        public Lugar(string nombre, double mtsCuadrados, bool tipo, bool accesibilidad, double mantenimiento, int aforoNativo, int aforoPermitido)
        {
            Nombre = nombre;
            MtsCuadrados = mtsCuadrados;
            Tipo = tipo;
            Accesibilidad = accesibilidad;
            Mantenimiento = mantenimiento;
            AforoNativo = aforoNativo;
            AforoPermitido = aforoPermitido;
            IdLugar = UltimoIdLugar;
            UltimoIdLugar++;
        }
    }
}
