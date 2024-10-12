using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Refacciones
    {
        public Refacciones(int idr, string codigoBarras, string nombre, string descripcion, string marca)
        {
            Idr = idr;
            CodigoBarras = codigoBarras;
            Nombre = nombre;
            Descripcion = descripcion;
            Marca = marca;
        }

        public int Idr { get; set; }
        public string CodigoBarras { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
    }
}
