using Manejador;
using System;
using System.Windows.Forms;
using Entidades;

namespace SistemaPermisosUsuarios
{
    public partial class FrmRefacciones : Form
    {
        ManejadorRefacciones mr;
        ManejadorLogin ml;
        public static Refacciones refacciones = new Refacciones(0,"", "", "","");
        int fila = 0, col = 0;
        public FrmRefacciones()
        {
            InitializeComponent();
            mr=new ManejadorRefacciones();
            ml= new ManejadorLogin();
        }

        private void dgvRefacciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;
                col = e.ColumnIndex;
                refacciones.Idr = int.Parse(dgvRefacciones.Rows[fila].Cells[0].Value.ToString());
                refacciones.CodigoBarras = dgvRefacciones.Rows[fila].Cells[1].Value.ToString();
                refacciones.Nombre = dgvRefacciones.Rows[fila].Cells[2].Value.ToString();
                refacciones.Descripcion = dgvRefacciones.Rows[fila].Cells[3].Value.ToString();
                refacciones.Marca = dgvRefacciones.Rows[fila].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvRefacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ra = ml.Permisos("actualizacion", FrmLogin.user, "Refacciones");
            var rel = ml.Permisos("eliminacion", FrmLogin.user, "Refacciones");
            switch (col)
            {
                case 5:
                    {
                        if (ra == true)
                        {
                            Hide();
                            FrmAddRefaccion far = new FrmAddRefaccion();
                            far.ShowDialog();
                            Actualizar();
                            Show();
                        }
                        else
                            MessageBox.Show("No tiene permisos de actualizacion");
                    }
                    break;
                case 6:
                    {
                        if(rel == true)
                        {
                            mr.Eliminar(refacciones);
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
            var re = ml.Permisos("escritura", FrmLogin.user, "Refacciones");
            if (re == true)
                Abrir();
            else
                MessageBox.Show("No tiene permisos de escritura");
        }

        public void Abrir()
        {
            Hide();
            refacciones.Idr = -1;
            FrmAddRefaccion far = new FrmAddRefaccion();
            far.ShowDialog();
            Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var rl = ml.Permisos("lectura", FrmLogin.user, "Refacciones");
            if (rl == true)
                Actualizar();
            else
                MessageBox.Show("No tiene permisos de lectura");
        }

        public void Actualizar()
        {
            mr.Mostrar(dgvRefacciones);
        }
    }
}
