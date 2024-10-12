using Entidades;
using Manejador;
using System;
using System.Windows.Forms;

namespace SistemaPermisosUsuarios
{
    public partial class FrmAddRefaccion : Form
    {
        ManejadorRefacciones mr;
        FrmRefacciones fr;
        Refacciones refacciones = null;

        public FrmAddRefaccion()
        {
            InitializeComponent();
            mr = new ManejadorRefacciones();
            fr = new FrmRefacciones();
            if (FrmRefacciones.refacciones.Idr > 0)
            {
                txtCodigo.Text = FrmRefacciones.refacciones.CodigoBarras;
                txtNombre.Text = FrmRefacciones.refacciones.Nombre;
                txtDescripcion.Text = FrmRefacciones.refacciones.Descripcion;
                txtMarca.Text = FrmRefacciones.refacciones.Marca;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmRefacciones.refacciones.Idr > 0)
            {
                mr.Modificar(new Refacciones(FrmRefacciones.refacciones.Idr, txtCodigo.Text,
                    txtNombre.Text, txtDescripcion.Text, txtMarca.Text));
                Close();
            }
            else
            {
                mr.Guardar(new Refacciones(FrmRefacciones.refacciones.Idr, txtCodigo.Text,
                    txtNombre.Text, txtDescripcion.Text, txtMarca.Text));
                Close();
            }
        }
    }
}
