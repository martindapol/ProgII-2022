namespace Carreras__SP.Presentacion
{
    partial class frmReporteCarrera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.carrerasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteCarrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteCarreras = new Carreras__SP.Presentacion.Reportes.Datos.DataSet2();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carrerasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteCarrerasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasTableAdapter = new Carreras__SP.Presentacion.Reportes.Datos.DataSet2TableAdapters.CarrerasTableAdapter();
            this.btnSalirReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteCarrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteCarrerasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // carrerasBindingSource2
            // 
            this.carrerasBindingSource2.DataMember = "Carreras";
            this.carrerasBindingSource2.DataSource = this.dSReporteCarrerasBindingSource;
            // 
            // dSReporteCarrerasBindingSource
            // 
            this.dSReporteCarrerasBindingSource.DataSource = this.dSReporteCarreras;
            this.dSReporteCarrerasBindingSource.Position = 0;
            // 
            // dSReporteCarreras
            // 
            this.dSReporteCarreras.DataSetName = "DSReporteCarreras";
            this.dSReporteCarreras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "Carreras";
            this.carrerasBindingSource.DataSource = this.dSReporteCarrerasBindingSource;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.carrerasBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carreras__SP.Presentacion.Reportes.Diseño.ReporteCarreras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1024, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // carrerasBindingSource1
            // 
            this.carrerasBindingSource1.DataMember = "Carreras";
            this.carrerasBindingSource1.DataSource = this.dSReporteCarrerasBindingSource;
            // 
            // dSReporteCarrerasBindingSource1
            // 
            this.dSReporteCarrerasBindingSource1.DataSource = this.dSReporteCarreras;
            this.dSReporteCarrerasBindingSource1.Position = 0;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalirReporte
            // 
            this.btnSalirReporte.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalirReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirReporte.Location = new System.Drawing.Point(413, 485);
            this.btnSalirReporte.Name = "btnSalirReporte";
            this.btnSalirReporte.Size = new System.Drawing.Size(186, 43);
            this.btnSalirReporte.TabIndex = 1;
            this.btnSalirReporte.Text = "Salir";
            this.btnSalirReporte.UseVisualStyleBackColor = false;
            this.btnSalirReporte.Click += new System.EventHandler(this.btnSalirReporte_Click);
            // 
            // frmReporteCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 540);
            this.Controls.Add(this.btnSalirReporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteCarrera";
            this.Text = "frmReporteCarrera";
            this.Load += new System.EventHandler(this.frmReporteCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteCarrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteCarrerasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dSReporteCarrerasBindingSource;
        private Reportes.Datos.DataSet2 dSReporteCarreras;
        private System.Windows.Forms.BindingSource dSReporteCarrerasBindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private Reportes.Datos.DataSet2TableAdapters.CarrerasTableAdapter carrerasTableAdapter;
        private System.Windows.Forms.BindingSource carrerasBindingSource2;
        private System.Windows.Forms.BindingSource carrerasBindingSource1;
        private System.Windows.Forms.Button btnSalirReporte;
    }
}