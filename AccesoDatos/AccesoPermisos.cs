using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class AccesoPermisos
    {
        ConectarBD b = new ConectarBD("localhost", "root", "", "sistema");

        public void Guardar(Permisos permisos)
        {
            b.Comando(string.Format("call insertarpermisos({0},'{1}',{2},{3},{4},{5})",permisos.Usuario,
                permisos.Formulario,permisos.Lectura,permisos.Escritura,permisos.Actualizacion,
                permisos.Eliminacion));
        }
        public void Modificar(Permisos permisos)
        {
            b.Comando(string.Format("call modificarpermisos({0},{1},{2},{3},{4})",permisos.IdP,
                permisos.Lectura,permisos.Escritura,permisos.Actualizacion,permisos.Eliminacion));
        }
        public void Eliminar(Permisos permisos)
        {
            b.Comando(string.Format("call eliminarpermisos({0})", permisos.IdP));
        }
        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("call mostrarpermisos();"),"permisos");
        }
        public DataSet Usuarios()
        {
            return b.Obtener(string.Format("SELECT id, nombre FROM usuarios;"), "usuarios");
        }
    }
}
