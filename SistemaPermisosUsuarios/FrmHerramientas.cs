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

namespace SistemaPermisosUsuarios
{
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramientas mh;
        public static Herramientas herramientas = new Herramientas(0,"","","","","");
        int fila = 0, col = 0;
        public FrmHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }

        private void dgvHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 6:
                    {
                        Hide();
                        FrmAddHerramientas fah = new FrmAddHerramientas();
                        fah.ShowDialog();
                        Actualizar();
                        Show();
                    }
                    break;
                case 7:
                    {
                        mh.Eliminar(herramientas);
                        Actualizar();
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            herramientas.Idh = -1;
            FrmAddHerramientas fah = new FrmAddHerramientas();
            fah.ShowDialog();
            Show();
        }

        private void dgvHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            mh.Mostrar(dgvHerramientas);
        }
    }
}
