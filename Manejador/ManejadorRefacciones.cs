using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejadorRefacciones
    {
        AccesoRefacciones ar = new AccesoRefacciones();
        Grafico g = new Grafico();
        public void Guardar(Refacciones refacciones)
        {
            ar.Guardar(refacciones);
            g.Mensaje("Refaccion guardada", "¡atecion¡", MessageBoxIcon.Information);

        }
        public void Modificar(Refacciones refacciones)
        {
            ar.Modificar(refacciones);
            g.Mensaje("Refaccion actualizada", "¡atecion¡", MessageBoxIcon.Information);

        }
        public void Eliminar(Refacciones refacciones)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas seguro de borrar: {0}", refacciones.Nombre), "!Atencion!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ar.Eliminar(refacciones);
        }
        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ar.Mostrar().Tables["refacciones"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }

    public class Grafico
    {
        public void Mensaje(string t, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(t, titulo, MessageBoxButtons.OK, icono);
        }
        public DataGridViewButtonColumn Boton(string titulo, Color color)
        {
            DataGridViewButtonColumn c = new DataGridViewButtonColumn();
            c.Text = titulo;
            c.DefaultCellStyle.BackColor = color;
            c.UseColumnTextForButtonValue = true;
            return c;
        }
    }
}
