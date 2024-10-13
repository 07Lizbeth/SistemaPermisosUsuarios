using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;
using Entidades;

namespace SistemaPermisosUsuarios
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public static Usuarios usuarios = new Usuarios(0,"","","","","","");
        int fila = 0, col = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 7:
                    {
                        Hide();
                        FrmUpdateUsuarios fuu = new FrmUpdateUsuarios();
                        fuu.ShowDialog();
                        Actualizar();
                        Show();
                    }
                    break;
                case 8:
                    {
                        mu.Eliminar(usuarios);
                        Actualizar();
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            usuarios.Id = -1;
            FrmAddUsuarios fau = new FrmAddUsuarios();
            fau.ShowDialog();
            Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;
                col = e.ColumnIndex;
                usuarios.Id = int.Parse(dgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                usuarios.Nombre = dgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                usuarios.ApellidoP = dgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                usuarios.ApellidoM = dgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                usuarios.F_Nacimiento = dgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                usuarios.Rfc = dgvUsuarios.Rows[fila].Cells[5].Value.ToString();
                usuarios.Password = dgvUsuarios.Rows[fila].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Actualizar()
        {
            mu.Mostrar(dgvUsuarios);
        }

    }
}
