using CarpinteriaApp.datos;
using CarpinteriaApp.Servicios;
using CarpinteriaApp.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpinteriaApp.formularios
{
    public partial class FrmReporteProducto : Form
    {
        private IServicio servicio;
        public FrmReporteProducto(FabricaServicio fabrica)
        {
            InitializeComponent();
            servicio = fabrica.CrearServicio();

        }

        private void FrmReporteProducto_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-30);
            dtpHasta.Value = DateTime.Now;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataTable dt = servicio.ObtenerReporteProductos(dtpDesde.Value, dtpHasta.Value);
            rvReporte.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            rvReporte.RefreshReport();

        }
    }
}
