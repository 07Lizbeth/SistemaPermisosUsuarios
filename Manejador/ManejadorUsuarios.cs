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
    public class ManejadorUsuarios
    {
        AccesoUsuarios au=new AccesoUsuarios();
        Grafico g=new Grafico();
        public void Guardar(Usuarios usuarios)
        {
            au.Guardar(usuarios);
            g.Mensaje("Usuario Registrado", "¡atecion¡", MessageBoxIcon.Information);
        }
        public void Modificar(int id,string password)
        {
            au.Modificar(id,password);
            g.Mensaje("Usuario actualizado", "¡atecion¡", MessageBoxIcon.Information);
        }
        public void Eliminar(Usuarios usuarios)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas seguro de borrar: {0}", usuarios.Nombre), "!Atencion!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                au.Eliminar(usuarios);
        }
        public bool Password(string nombre, string password)
        {
            return au.Validar(nombre,password);
        }
        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = au.Mostrar().Tables["usuarios"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
            tabla.Columns[6].Visible = false;
        }
    }
}
