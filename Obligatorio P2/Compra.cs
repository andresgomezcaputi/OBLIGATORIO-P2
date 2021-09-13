using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    class Compra
    {
        private static int UltimoIdCompra = 1;
        public int IdCompra { get; set; }   
        public Actividad Actividad { get; set; }
        public int CantidadEntradas { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaHora { get; set; }
        public bool Estado { get; set; }
        public double PrecioFinalPagar { get; set; }

        public Compra(Actividad actividad, int cantidadEntradas, Usuario usuario, DateTime fechaHora, bool estado, double precioFinalPagar)
        {
            Actividad = actividad;
            CantidadEntradas = cantidadEntradas;
            Usuario = usuario;
            FechaHora = fechaHora;
            Estado = estado;
            PrecioFinalPagar = precioFinalPagar;
            IdCompra = UltimoIdCompra;
            UltimoIdCompra++;
        }
    }

}
