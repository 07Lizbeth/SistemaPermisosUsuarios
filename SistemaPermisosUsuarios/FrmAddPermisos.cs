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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Runtime.Remoting.Messaging;

namespace SistemaPermisosUsuarios
{
    public partial class FrmAddPermisos : Form
    {
        ManejadorPermisos mp;
        ManejadorUsuarios mu;
        FrmPermisos fp;
        Permisos permisos = null;
        int user;
        public FrmAddPermisos()
        {
            InitializeComponent();
            mp=new ManejadorPermisos();
            fp = new FrmPermisos();
            mu=new ManejadorUsuarios();
            Usuarios();
            if (FrmPermisos.permisos.IdP > 0)
            {
                cbUsuario.Visible = false;
                cbFormulario.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                cboxLectura.Checked = FrmPermisos.permisos.Lectura;
                cboxEscritura.Checked = FrmPermisos.permisos.Escritura;
                cboxActualizacion.Checked = FrmPermisos.permisos.Actualizacion;
                cboxEliminacion.Checked = FrmPermisos.permisos.Eliminacion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPermisos.permisos.IdP > 0)
            {
                mp.Modificar(new Permisos(FrmPermisos.permisos.IdP, FrmPermisos.permisos.Usuario,
                    FrmPermisos.permisos.Formulario, cboxLectura.Checked, cboxEscritura.Checked,
                    cboxActualizacion.Checked, cboxEliminacion.Checked));
                Close();
            }
            else
            {
                mp.Guardar(new Permisos(FrmPermisos.permisos.IdP, int.Parse(cbUsuario.SelectedValue.ToString()),
                    cbFormulario.Text, cboxLectura.Checked, cboxEscritura.Checked,
                    cboxActualizacion.Checked, cboxEliminacion.Checked));
                Close();
            } 
        }
        public void Usuarios()
        {
            mp.Usuarios(cbUsuario);

        }
    }
}
