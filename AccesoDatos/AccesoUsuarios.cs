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
            b.Comando(string.Format("call insertar('{0}','{1}')", usuarios.Usuario,
                usuarios.Password));
        }

        public void Modificar(Usuarios usuarios)
        {
            b.Comando(string.Format("call modificar({0},'{1}','{2}')", usuarios.Id,
                usuarios.Usuario,usuarios.Password));
        }

        public bool Password(string usuario, string password)
        {
            return b.Dato(string.Format("call validarusuario('{0}','{1}');", usuario,password));
        }
    }
}
