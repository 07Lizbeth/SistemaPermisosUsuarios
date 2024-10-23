using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorLogin
    {
        AccesoLogin al=new AccesoLogin();
        public bool Password(string nombre, string password)
        {
            return al.Validar(nombre, password);
        }
        public string Informacion(string columna, string tabla, string where, string parametro)
        {
            return al.Informacion(columna, tabla, where, parametro);
        }
        public bool Permisos(string columna, string parametro1, string parametro2)
        {
            return  al.Permisos(columna, parametro1, parametro2);
        }
    }
}
