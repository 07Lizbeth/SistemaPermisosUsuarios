using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoRefacciones
    {
        ConectarBD b = new ConectarBD("localhost", "root", "", "sistema");

        public void Guardar(Refacciones refacciones)
        {
            b.Comando(string.Format("call insertarrefacciones('{0}','{1}','{2}','{3}')", 
                refacciones.CodigoBarras,refacciones.Nombre,refacciones.Descripcion,refacciones.Marca));
        }
        public void Modificar(Refacciones refacciones)
        {
            b.Comando(string.Format("call modificarrefacciones({0},'{1}','{2}','{3}','{4}')",
                refacciones.Idr, refacciones.CodigoBarras, refacciones.Nombre, 
                refacciones.Descripcion, refacciones.Marca));
        }
        public void Eliminar(Refacciones refacciones)
        {
            b.Comando(string.Format("call eliminarrefacciones('{0}')", refacciones.CodigoBarras));
        }
        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("select * from refacciones;"), "refacciones");
        }
    }
}
