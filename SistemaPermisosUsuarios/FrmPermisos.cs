using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace SistemaPermisosUsuarios
{
    public partial class FrmPermisos : Form
    {
        ManejadorPermisos mp;
        ManejadorLogin ml;
        public static Permisos permisos = new Permisos(0,0,"",false,false,false,false);
        int fila = 0, col = 0;
        public FrmPermisos()
        {
            InitializeComponent();
            mp=new ManejadorPermisos();
            ml= new ManejadorLogin();   
        }

        private void dgvPermisos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;
                col = e.ColumnIndex;
                permisos.IdP = int.Parse(dgvPermisos.Rows[fila].Cells[0].Value.ToString());
                permisos.Usuario = int.Parse(dgvPermisos.Rows[fila].Cells[1].Value.ToString());
                permisos.Formulario = dgvPermisos.Rows[fila].Cells[2].Value.ToString();
                permisos.Lectura = bool.Parse(dgvPermisos.Rows[fila].Cells[3].Value.ToString());
                permisos.Escritura = bool.Parse(dgvPermisos.Rows[fila].Cells[4].Value.ToString());
                permisos.Actualizacion = bool.Parse(dgvPermisos.Rows[fila].Cells[5].Value.ToString());
                permisos.Eliminacion = bool.Parse(dgvPermisos.Rows[fila].Cells[6].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var pa = ml.Permisos("actualizacion", FrmLogin.user, "Permisos");
            var pel = ml.Permisos("eliminacion", FrmLogin.user, "Permisos");
            switch (col)
            {
                case 7:
                    {
                        if (pa == true)
                        {
                            Hide();
                            FrmAddPermisos fap = new FrmAddPermisos();
                            fap.ShowDialog();
                            Actualizar();
                            Show();
                        }
                        else
                            MessageBox.Show("No tiene permisos de actualizacion");
                    }
                    break;
                case 8:
                    {
                        if(pel == true)
                        {
                            mp.Eliminar(permisos);
                            Actualizar();
                        }
                        else
                            MessageBox.Show("No tiene permisos de eliminacion");
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var pe = ml.Permisos("escritura", FrmLogin.user, "Permisos");
            if (pe == true)
                Abrir();
            else
                MessageBox.Show("No tiene permisos de escritura");
        }

        public void Abrir()
        {
            Hide();
            permisos.IdP = -1;
            FrmAddPermisos fap = new FrmAddPermisos();
            fap.ShowDialog();
            Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var pl = ml.Permisos("lectura", FrmLogin.user, "Permisos");
            if (pl == true)
                Actualizar();
            else
                MessageBox.Show("No tiene permisos de lectura");
        }

        public void Actualizar()
        {
            mp.Mostrar(dgvPermisos);
        }
    }
}
