using System;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace SistemaPermisosUsuarios
{
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramientas mh;
        ManejadorLogin ml;
        public static Herramientas herramientas = new Herramientas(0,"","","","","");
        int fila = 0, col = 0;
        public FrmHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
            ml = new ManejadorLogin();
        }

        private void dgvHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;
                col = e.ColumnIndex;
                herramientas.Idh = int.Parse(dgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                herramientas.CodigoHerramienta = dgvHerramientas.Rows[fila].Cells[1].Value.ToString();
                herramientas.Nombre = dgvHerramientas.Rows[fila].Cells[2].Value.ToString();
                herramientas.Medida = dgvHerramientas.Rows[fila].Cells[3].Value.ToString();
                herramientas.Marca = dgvHerramientas.Rows[fila].Cells[4].Value.ToString();
                herramientas.Descripcion = dgvHerramientas.Rows[fila].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ta = ml.Permisos("actualizacion", FrmLogin.user, "Taller");
            var tel = ml.Permisos("eliminacion", FrmLogin.user, "Taller");
            switch (col)
            {
                case 6:
                    {
                        if (ta == true)
                        {
                            Hide();
                            FrmAddHerramientas fah = new FrmAddHerramientas();
                            fah.ShowDialog();
                            Actualizar();
                            Show();
                        }
                        else
                            MessageBox.Show("No tiene permisos de actualizacion");
                    }
                    break;
                case 7:
                    {
                        if (tel == true)
                        {
                            mh.Eliminar(herramientas);
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
            var te = ml.Permisos("escritura", FrmLogin.user, "Taller");
            if (te == true)
                Abrir();
            else
                MessageBox.Show("No tiene permisos de escritura");
        }

        public void Abrir()
        {
            Hide();
            herramientas.Idh = -1;
            FrmAddHerramientas fah = new FrmAddHerramientas();
            fah.ShowDialog();
            Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var tl = ml.Permisos("lectura", FrmLogin.user, "Taller");
            if (tl == true)
                Actualizar();
            else
                MessageBox.Show("No tiene permisos de lectura");
        }

        public void Actualizar()
        {
            mh.Mostrar(dgvHerramientas);
        }
    }
}
