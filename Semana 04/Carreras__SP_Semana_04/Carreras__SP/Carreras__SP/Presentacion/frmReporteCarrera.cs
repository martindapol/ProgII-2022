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
    public partial class frmReporteCarrera : Form
    {
        public frmReporteCarrera()
        {
            InitializeComponent();
        }

        private void frmReporteCarrera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSReporteCarreras.Carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.dSReporteCarreras.Carreras);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnSalirReporte_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
