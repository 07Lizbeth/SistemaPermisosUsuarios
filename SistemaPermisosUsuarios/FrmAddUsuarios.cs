using Amazon.Runtime.Internal.Auth;
using Entidades;
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

namespace SistemaPermisosUsuarios
{
    public partial class FrmAddUsuarios : Form
    {
        ManejadorUsuarios mu;
        public FrmAddUsuarios()
        {
            InitializeComponent();
            mu=new ManejadorUsuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            mu.Guardar(new Usuarios(FrmUsuarios.usuarios.Id, txtNombre.Text,txtApellidop.Text,
                txtApellidom.Text,mtxtNacimiento.Text,txtRfc.Text,txtPassword.Text));
            Close();
        }
    }
}
