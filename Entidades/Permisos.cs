using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        public Permisos(int idP, int usuario, string formulario, bool lectura, bool escritura, bool actualizacion, bool eliminacion)
        {
            IdP = idP;
            Usuario = usuario;
            Formulario = formulario;
            Lectura = lectura;
            Escritura = escritura;
            Actualizacion = actualizacion;
            Eliminacion = eliminacion;
        }

        public int IdP { get; set; }
        public int Usuario { get; set; }
        public string Formulario { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Actualizacion { get; set; }
        public bool Eliminacion { get; set; }
    }
}
