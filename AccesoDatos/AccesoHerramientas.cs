using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoHerramientas
    {
        ConectarBD b = new ConectarBD("localhost", "root", "", "sistema");

        public void Guardar(Herramientas herramientas)
        {
            b.Comando(string.Format("call insertarherramientas('{0}','{1}','{2}','{3}','{4}')",
                herramientas.CodigoHerramienta,herramientas.Nombre,herramientas.Medida,herramientas.Marca,herramientas.Descripcion));
        }
        public void Modificar(Herramientas herramientas)
        {
            b.Comando(string.Format("call modificarherramientas({0},'{1}','{2}','{3}','{4}','{5}')",
                herramientas.Idh,herramientas.CodigoHerramienta,herramientas.Nombre,herramientas.Medida,
                herramientas.Marca,herramientas.Descripcion));
        }
        public void Eliminar(Herramientas herramientas)
        {
            b.Comando(string.Format("call eliminarherramientas({0})", herramientas.Idh));
        }
        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("select * from herramientas;"), "herramientas");
        }
    }
}
