using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoUsuarios
    {
        ConectarBD b = new ConectarBD("localhost", "root", "", "sistema");

        public void Guardar(Usuarios usuarios)
        {
            b.Comando(string.Format("call insertar('{0}','{1}')", usuarios.Nombre,
                usuarios.Password));
        }

        public void Modificar(Usuarios usuarios)
        {
            b.Comando(string.Format("call modificar({0},'{1}','{2}')", usuarios.Id,
                usuarios.Nombre,usuarios.Password));
        }

        public bool Validar(string nombre, string password)
        {
            return b.Dato(string.Format("call validarusuario('{0}','{1}');", nombre,password));
        }
    }
}
