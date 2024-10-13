using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPermisosUsuarios
{
    public partial class FrmPrincipal : Form
    {
        public static string show;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.GetWorkingArea(this);
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
            AbrirFormulario(fr);
        }

        private void tmsiTaller_Click(object sender, EventArgs e)
        {
            FrmHerramientas fh=new FrmHerramientas();
            AbrirFormulario(fh);
        }

        private void tmsiMUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios fm = new FrmUsuarios();
            AbrirFormulario(fm);
        }
    }
}
