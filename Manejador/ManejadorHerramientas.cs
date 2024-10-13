using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorHerramientas
    {
        AccesoHerramientas ah = new AccesoHerramientas();
        Grafico g = new Grafico();
        public void Guardar(Herramientas herramientas)
        {
            ah.Guardar(herramientas);
            g.Mensaje("Herramienta guardada", "¡atecion¡", MessageBoxIcon.Information);

        }
        public void Modificar(Herramientas herramientas)
        {
            ah.Modificar(herramientas);
            g.Mensaje("Herramienta actualizada", "¡atecion¡", MessageBoxIcon.Information);

        }
        public void Eliminar(Herramientas herramientas)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas seguro de borrar: {0}", herramientas.Nombre), "!Atencion!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ah.Eliminar(herramientas);
        }
        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ah.Mostrar().Tables["herramientas"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(7, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
