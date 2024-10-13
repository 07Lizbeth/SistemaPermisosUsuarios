using Entidades;
using Manejador;
using System;
using System.Windows.Forms;

namespace SistemaPermisosUsuarios
{
    public partial class FrmAddHerramientas : Form
    {
        ManejadorHerramientas mh;
        FrmHerramientas fh;
        Herramientas herramientas = null;
        public FrmAddHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
            fh = new FrmHerramientas();
            if (FrmHerramientas.herramientas.Idh > 0)
            {
                txtCodigo.Text = FrmHerramientas.herramientas.CodigoHerramienta;
                txtNombre.Text = FrmHerramientas.herramientas.Nombre;
                txtMedida.Text = FrmHerramientas.herramientas.Medida;
                txtMarca.Text = FrmHerramientas.herramientas.Marca;
                txtDescripcion.Text = FrmHerramientas.herramientas.Descripcion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmHerramientas.herramientas.Idh > 0)
            {
                mh.Modificar(new Herramientas(FrmHerramientas.herramientas.Idh, txtCodigo.Text,
                    txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text));
                Close();
            }
            else
            {
                mh.Guardar(new Herramientas(FrmHerramientas.herramientas.Idh, txtCodigo.Text,
                    txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text));
                Close();
            }
        }
    }
}
