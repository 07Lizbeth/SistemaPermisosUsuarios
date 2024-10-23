using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;
using MySqlX.XDevAPI;

namespace SistemaPermisosUsuarios
{
    public partial class FrmLogin : Form
    {
        public static string nombre;
        public static string user;
        //public static Boolean Usuario, Permiso, Refaccion, Taller;
        ManejadorLogin ml;
        public FrmLogin()
        {
            InitializeComponent();
            ml=new ManejadorLogin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            nombre = ml.Informacion("nombre", "usuarios", "nombre", txtUsuario.Text);
            user=ml.Informacion("id","usuarios","nombre",txtUsuario.Text);
            string password = txtPassword.Text;
            if (ml.Password(nombre,password))
            {
                Hide();
                FrmPrincipal fp = new FrmPrincipal();
                fp.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Nombre y/o Contraseña no son correctos");
            }
        }
    }
}
