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
    public class ManejadorPermisos
    {
        AccesoPermisos ap = new AccesoPermisos();
        Grafico g = new Grafico();
        public void Guardar(Permisos permisos)
        {
            ap.Guardar(permisos);
            g.Mensaje("Permiso guardado", "¡atecion¡", MessageBoxIcon.Information);

        }
        public void Modificar(Permisos permisos)
        {
            ap.Modificar(permisos);
            g.Mensaje("Permiso actualizado", "¡atecion¡", MessageBoxIcon.Information);

        }
        public void Eliminar(Permisos permisos)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas seguro de borrar el permiso"), "!Atencion!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Eliminar(permisos);
        }
        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar().Tables["permisos"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
        public void Usuarios(ComboBox comboBox)
        {
            comboBox.DataSource=ap.Usuarios().Tables["usuarios"];
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "Id";

        }
    }
}
