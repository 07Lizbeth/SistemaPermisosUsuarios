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
    public partial class FrmUpdateUsuarios : Form
    {
        ManejadorUsuarios mu;
        FrmUsuarios fu;
        Usuarios usuarios = null;
        public FrmUpdateUsuarios()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();
            fu=new FrmUsuarios();
            if (FrmUsuarios.usuarios.Id > 0)
            {
                txtPassword.Text = FrmUsuarios.usuarios.Password;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.usuarios.Id > 0)
            {
                mu.Modificar(FrmUsuarios.usuarios.Id, txtPassword.Text);
                Close();
            }
        }
    }
}
