using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejador;
using Org.BouncyCastle.Ocsp;

namespace SistemaPermisosUsuarios
{
    public partial class FrmPrincipal : Form
    {
        public static string show;
        public static string user;
        FrmLogin fl;
        ManejadorLogin ml;
        public FrmPrincipal()
        {
            InitializeComponent();
            ml = new ManejadorLogin();
            fl = new FrmLogin();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            lblUsuario.Text = FrmLogin.nombre;
        }

        private void AbrirFormulario(Form formulario)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);

            formulario.TopLevel = false;  
            formulario.Dock = DockStyle.Fill;  
            this.pnlPrincipal.Controls.Add(formulario);  
            this.pnlPrincipal.Tag = formulario;  
            formulario.Show();  
        }

        private void tmsiRefacciones_Click(object sender, EventArgs e)
        {
            FrmRefacciones fr=new FrmRefacciones();
            var rl = ml.Permisos("lectura", FrmLogin.user, "Refacciones");
            var re = ml.Permisos("escritura", FrmLogin.user, "Refacciones");
            var ra = ml.Permisos("actualizacion", FrmLogin.user, "Refacciones");
            var rel = ml.Permisos("eliminacion", FrmLogin.user, "Refacciones");

            if (rl || re || ra || rel)
                AbrirFormulario(fr);
            else
                MessageBox.Show("El usuario no tiene permisos para este formulario");
        }

        private void tmsiTaller_Click(object sender, EventArgs e)
        {
            FrmHerramientas fh=new FrmHerramientas();
            var tl = ml.Permisos("lectura", FrmLogin.user, "Taller");
            var te = ml.Permisos("escritura", FrmLogin.user, "Taller");
            var ta = ml.Permisos("actualizacion", FrmLogin.user, "Taller");
            var tel = ml.Permisos("eliminacion", FrmLogin.user, "Taller");

            if (tl || te || ta || tel)
                AbrirFormulario(fh);
            else
                MessageBox.Show("El usuario no tiene permisos para este formulario");

        }

        private void tmsiMUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios fu = new FrmUsuarios();
            var ul = ml.Permisos("lectura", FrmLogin.user, "Usuarios");
            var ue = ml.Permisos("escritura", FrmLogin.user, "Usuarios");
            var ua = ml.Permisos("actualizacion", FrmLogin.user, "Usuarios");
            var uel = ml.Permisos("eliminacion", FrmLogin.user, "Usuarios");

            if (ul || ue || ua || uel)
                AbrirFormulario(fu);
            else
                MessageBox.Show("El usuario no tiene permisos para este formulario");
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPermisos fp = new FrmPermisos();
            var pl = ml.Permisos("lectura", FrmLogin.user, "Permisos");
            var pe = ml.Permisos("escritura", FrmLogin.user, "Permisos");
            var pa = ml.Permisos("actualizacion", FrmLogin.user, "Permisos");
            var pel = ml.Permisos("eliminacion", FrmLogin.user, "Permisos");

            if (pl || pe || pa || pel)
                AbrirFormulario(fp);
            else
                MessageBox.Show("El usuario no tiene permisos para este formulario");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin fl = new FrmLogin();
            fl.ShowDialog();
            Close();
        }
    }
}
