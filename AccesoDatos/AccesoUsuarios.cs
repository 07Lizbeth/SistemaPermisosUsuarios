using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
            b.Comando(string.Format("call insertarusuarios('{0}','{1}','{2}','{3}','{4}','{5}')", usuarios.Nombre,
                usuarios.ApellidoP,usuarios.ApellidoM,usuarios.F_Nacimiento,usuarios.Rfc,usuarios.Password));
        }

        public void Modificar(int id,string password)
        {
            b.Comando(string.Format("call modificarusuario({0},'{1}')", id,password));
        }

        public void Eliminar(Usuarios usuarios) 
        {
            b.Comando(string.Format("call eliminarusuario({0})", usuarios.Id));
        }

        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("select * from usuarios;"), "usuarios");

        }
        public bool Validar(string nombre, string password)
        {
            return b.Dato(string.Format("call validarusuario('{0}','{1}');", nombre,password));
        }
    }
}
