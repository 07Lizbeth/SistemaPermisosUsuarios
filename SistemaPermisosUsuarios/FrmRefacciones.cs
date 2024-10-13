using Manejador;
using System;
using System.Windows.Forms;
using Entidades;

namespace SistemaPermisosUsuarios
{
    public partial class FrmRefacciones : Form
    {
        ManejadorRefacciones mr;
        public static Refacciones refacciones = new Refacciones(0,"", "", "","");
        int fila = 0, col = 0;
        public FrmRefacciones()
        {
            InitializeComponent();
            mr=new ManejadorRefacciones();
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
            switch (col)
            {
                case 5:
                    {
                        Hide();
                        FrmAddRefaccion far = new FrmAddRefaccion();
                        far.ShowDialog();
                        Actualizar();
                        Show();
                    }
                    break;
                case 6:
                    {
                        mr.Eliminar(refacciones);
                        Actualizar();
                    }
                    break;
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            refacciones.Idr = -1;
            FrmAddRefaccion far=new FrmAddRefaccion();
            far.ShowDialog();
            Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            mr.Mostrar(dgvRefacciones);
        }
    }
}
