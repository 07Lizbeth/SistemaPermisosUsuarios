﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Herramientas
    {
        public Herramientas(int idh, string codigoHerramienta, string nombre, string medida, string marca, string descripcion)
        {
            Idh = idh;
            CodigoHerramienta = codigoHerramienta;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public int Idh { get; set; }
        public string CodigoHerramienta { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
