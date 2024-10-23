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
using Org.BouncyCastle.Math.EC.Endo;

namespace SistemaPermisosUsuarios
{
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        ManejadorLogin ml;
        public static Usuarios usuarios = new Usuarios(0,"","","","","","");
        int fila = 0, col = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();
            ml=new ManejadorLogin();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var ua = ml.Permisos("actualizacion", FrmLogin.user, "Usuarios");
            var uel = ml.Permisos("eliminacion", FrmLogin.user, "Usuarios");
            switch (col)
            {
                case 7:
                    {
                        if (ua == true)
                        {
                            Hide();
                            FrmUpdateUsuarios fuu = new FrmUpdateUsuarios();
                            fuu.ShowDialog();
                            Actualizar();
                            Show();
                        }
                        else
                            MessageBox.Show("No tiene permisos de actualizacion");
                    }
                    break;
                case 8:
                    {
                        if(uel == true)
                        {
                            mu.Eliminar(usuarios);
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
            var ue = ml.Permisos("escritura", FrmLogin.user, "Usuarios");
            if (ue == true)
                Abrir();
            else
                MessageBox.Show("No tiene permisos de escritura");

        }
        public void Abrir()
        {
            Hide();
            usuarios.Id = -1;
            FrmAddUsuarios fau = new FrmAddUsuarios();
            fau.ShowDialog();
            Show();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var ul = ml.Permisos("lectura", FrmLogin.user, "Usuarios");
            if (ul == true)
                Actualizar();
            else
                MessageBox.Show("No tiene permisos de lectura");
        }

        public void Actualizar()
        {
            mu.Mostrar(dgvUsuarios);
        }

    }
}
