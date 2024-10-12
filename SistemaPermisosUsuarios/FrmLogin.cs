using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;

namespace SistemaPermisosUsuarios
{
    public partial class FrmLogin : Form
    {
        ManejadorUsuarios mu;
        public FrmLogin()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string password = txtPassword.Text;
            if (mu.Password(nombre,password))
            {
                FrmPrincipal p=new FrmPrincipal();
                p.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Número de Identificación y/o Contraseña no son correctos");
            }
        }
    }
}
