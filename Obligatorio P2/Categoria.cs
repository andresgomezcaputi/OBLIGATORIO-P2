﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio_P2
{
    class Categoria
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Categoria(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
