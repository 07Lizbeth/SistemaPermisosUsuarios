using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
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
