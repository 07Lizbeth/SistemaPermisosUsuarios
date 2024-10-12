using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejadorUsuarios
    {
        AccesoUsuarios au=new AccesoUsuarios();
        public void Guardar(Usuarios usuarios)
        {
            au.Guardar(usuarios);
        }
        public void Modificar(Usuarios usuarios)
        {
            au.Modificar(usuarios);
        }
        public bool Password(string usuario, string password)
        {
            return au.Password(usuario,password);
        }
    }
}
