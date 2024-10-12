using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int id, string nombre, string apellidoP, string apellidoM, string f_Nacimiento, string rfc, string password)
        {
            Id = id;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            F_Nacimiento = f_Nacimiento;
            Rfc = rfc;
            Password = password;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string F_Nacimiento { get; set; }
        public string Rfc { get; set; }
        public string Password { get; set; }
    }
}
