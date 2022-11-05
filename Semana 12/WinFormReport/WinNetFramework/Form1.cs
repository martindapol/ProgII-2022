using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=db_carpinteria;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select t.presupuesto_nro as presupuesto,t.cliente as cliente, t.total as total  FROM T_Presupuestos t order by t.fecha", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new
            ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
        }
    }
}
