using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras__SP.Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ Desea salir de la aplicación ?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaCarrera nuevaCarrera = new frmNuevaCarrera();
            nuevaCarrera.ShowDialog();
        }

        private void consultarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCarrera consultarCarrera = new frmConsultarCarrera();
            consultarCarrera.ShowDialog();
        }

        private void verReporteDeCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCarrera reporteCarrrera = new frmReporteCarrera();
            reporteCarrrera.ShowDialog();
        }
    }
}
