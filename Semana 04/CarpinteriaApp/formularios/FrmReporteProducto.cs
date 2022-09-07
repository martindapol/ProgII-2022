using CarpinteriaApp.datos;
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
        public FrmReporteProducto()
        {
            InitializeComponent();
        }

        private void FrmReporteProducto_Load(object sender, EventArgs e)
        {
            HelperDB helperDB = new HelperDB();
            DataTable dt = helperDB.ConsultaSQL("SP_REPORTE_PRODUCTOS");
            rvReporte.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.rvReporte.RefreshReport(); ;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
